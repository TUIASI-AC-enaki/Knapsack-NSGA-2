using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using NSGA_II_Algorithm.implementations;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;

namespace NSGA_II_GUI
{
    public partial class NSGA : Form
    {
        private List<Item> _items;
        private List<Chromosome> _chromosomes;
        private INsgaAlgorithm _algorithm;

        public NSGA()
        {
            InitializeComponent();
            _items = new List<Item>();
            _chromosomes=new List<Chromosome>();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            richTextBoxInputCheck.AppendText($"\r\n[{Utils.GetCurrentTime()}] - ", Color.LightGreen);
            richTextBoxInputCheck.AppendText($"Start NSGA-II Algorithm\r\n", Color.DodgerBlue);

            richTextBoxInputCheck.AppendText($"[{Utils.GetCurrentTime()}] - ", Color.LightGreen);
            try
            {
                var maxGenerations = int.Parse(textBoxMaxGen.Text, CultureInfo.InvariantCulture);
                var populationSize = int.Parse(textBoxPopSize.Text, CultureInfo.InvariantCulture);
                var crossoverProbability = double.Parse(textBoxCrossover.Text, CultureInfo.InvariantCulture);
                var mutationProbability = double.Parse(textBoxMutation.Text, CultureInfo.InvariantCulture);
                _items.Clear();
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Index != dataGrid.Rows.Count - 1)
                    {
                        //temp.Add(row.Cells[0].Value.ToString());
                        var name = row.Cells[0].Value.ToString();
                        var weight = row.Cells[1].Value.ToString();
                        var cost = row.Cells[2].Value.ToString();
                        var time = row.Cells[3].Value.ToString();
                        _items.Add(new Item(name, double.Parse(weight), double.Parse(cost), double.Parse(time)));
                    }
                }

                if (maxGenerations <= 0 || populationSize <= 0||crossoverProbability<0||crossoverProbability>1||mutationProbability<0||mutationProbability>1)
                {
                    richTextBoxInputCheck.AppendText("Invalid input parameters\r\n", Color.Red);
                    return;
                }
                _algorithm = new NsgaAlgorithm(crossoverProbability, mutationProbability, _items);
                _chromosomes = _algorithm.Process(maxGenerations, populationSize);
                DrawGraphics(_chromosomes);


            }
            catch (FormatException)
            {
                richTextBoxInputCheck.AppendText($"Format Exception\r\n",Color.Red);
                return;
            }
            catch (NullReferenceException)
            {
                richTextBoxInputCheck.AppendText($"Null error\r\n",Color.Red);
                return;
            }
            richTextBoxInputCheck.AppendText($"Data Loaded Successfully\r\n", Color.GreenYellow);

            tabControl1.SelectTab(1);
        }

        private void DrawGraphics(List<Chromosome> chromosomesList)
        {
            NSGAChart.Series.Clear();
            NSGAChart.AxisX.Clear();
            NSGAChart.AxisY.Clear();
            var frontChromosomes = _algorithm.SortByFronts(chromosomesList);
            Console.Out.WriteLine();
            NSGAChart.Series = new SeriesCollection();
            for (var i = 0; i < frontChromosomes.Count; ++i)
            {
                var points = new ChartValues<ObservablePoint>();
                var sorted = frontChromosomes[i].OrderBy(chromosome => chromosome.GetFitnessByTime(_items));
                foreach (var chromosome in sorted)
                {
                    points.Add(new ObservablePoint { X = chromosome.GetFitnessByTime(_items), Y = chromosome.GetFitnessByCost(_items) });
                }
                NSGAChart.Series.Add(new LineSeries
                {
                    Title = "Front " + (i + 1),
                    Values = points
                });
            }

            NSGAChart.AxisX.Add(new Axis
            {
                Title = "Time",
            });
            NSGAChart.AxisY.Add(new Axis
            {
                Title = "Cost",
            });
            NSGAChart.DataClick += CartesianChart1OnDataClick;
            NSGAChart.LegendLocation = LegendLocation.Bottom;
            NSGAChart.Zoom = ZoomingOptions.Xy;
            NSGAChart.AnimationsSpeed = TimeSpan.FromMilliseconds(150);
        }

        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            
            var current=_chromosomes.Find(chromosome => chromosome.GetFitnessByTime(_items) == chartPoint.X &&
                                            chromosome.GetFitnessByCost(_items) == chartPoint.Y);
            
            richTextBoxGraph.Text = "";
            richTextBoxLootedItems.Text = "";

            richTextBoxGraph.AppendText("Selected Chromosome:\r\n\r\n", Color.ForestGreen);
            richTextBoxGraph.AppendText($"Size: {current.Size}\r\n", Color.DodgerBlue);
            richTextBoxGraph.AppendText($"Total Cost: {current.GetFitnessByCost(_items)}\r\n", Color.DodgerBlue);
            richTextBoxGraph.AppendText($"Total Time: {current.GetFitnessByTime(_items)}\r\n", Color.DodgerBlue);
            richTextBoxGraph.AppendText($"Total Weight: {current.GetFitnessByWeight(_items)}\r\n", Color.DodgerBlue);
            richTextBoxGraph.AppendText($"Genes: [{String.Join(" ",current.Selected.Select(value=>value?1:0))}]\r\n\r\n", Color.DarkOrange);

            richTextBoxLootedItems.AppendText("Looted items:\r\n", Color.DeepSkyBlue);
            foreach (var item in current.getSelectedItems(_items))
            {
                richTextBoxLootedItems.AppendText($"{item}", Color.DarkRed);
            }
        }

        private void btnDefaultData_Click(object sender, EventArgs e)
        {

            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();
            textBoxMaxGen.Text = "1";
            textBoxPopSize.Text = "100";
            textBoxCrossover.Text = "0.9";
            textBoxMutation.Text = "0.02";

            var items = GetDefaultItems();
            foreach(var item in items)
            {
                AddTableItem(item.Name, item.Weight.ToString(CultureInfo.InvariantCulture),
                    item.Price.ToString(CultureInfo.InvariantCulture),
                    item.TimeRequired.ToString(CultureInfo.InvariantCulture));
            }
            richTextBoxInputCheck.AppendText($"[{Utils.GetCurrentTime()}] - ", Color.LightGreen);
            richTextBoxInputCheck.AppendText($"Loaded Default Data Successfully\r\n", Color.Yellow);

        }

        private void AddTableItem(string name, string weight, string price, string time)
        {
            var row = (DataGridViewRow)dataGrid.Rows[0].Clone();
            row.Cells[0].Value = name;
            row.Cells[1].Value = double.Parse(weight);
            row.Cells[2].Value = double.Parse(price);
            row.Cells[3].Value = double.Parse(time);
            dataGrid.Rows.Add(row);
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();
            richTextBoxInputCheck.AppendText($"[{Utils.GetCurrentTime()}] - ", Color.LightGreen);
            richTextBoxInputCheck.AppendText($"Reset Data Successfully\r\n", Color.DarkGoldenrod);
        }


        static IEnumerable<Item> GetDefaultItems()
        {
            var list = new List<Item>
            {
                new Item("Unicorn", 40, 300, 10),
                new Item("Galeata", 2, 30, 8),
                new Item("Mar", 0.2, 3, 3),
                new Item("Sticla", 0.7, 4, 0.2),
                new Item("Telefon",70,75,2.5),
                new Item("Banane",0.2,2,3),
                new Item("Parfum",0.4,50,4),
                new Item("Acumulator",0.6,150,8),
                new Item("Televizor",10,80,15),
                new Item("Lanterna",0.2,30,2.2),
                new Item("Calculator",10,44,20),
                new Item("Portofel cu bani",0.1,40,5),
                new Item("Elicopter RC",0.5,130,20),
                new Item("MASA DE TENIS",20,45,12),
                new Item("Biscuiti Oreo", 0.5, 5, 5)

            };
            return list;
        }

        private void buttonMaxWeightFilter_Click(object sender, EventArgs e)
        {
            richTextBoxInputCheck.AppendText($"[{Utils.GetCurrentTime()}] - ", Color.LightGreen);
            if (!double.TryParse(textBoxMaxWeight.Text, out var weight))
            {
                richTextBoxInputCheck.AppendText($"Invalid Weight. Can not filter data.\r\n", Color.Red);
                return;
            };
            var filteredChromosome = _chromosomes.Where(chr => chr.GetFitnessByWeight(_items) <= weight).ToList();
            DrawGraphics(filteredChromosome);
            richTextBoxInputCheck.AppendText($"Data Filtered successfully by {weight}.\r\n", Color.Cyan);
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                if (row.Index + 1 != dataGrid.Rows.Count)
                {
                    dataGrid.Rows.RemoveAt(row.Index);
                }
            }
            richTextBoxInputCheck.AppendText($"[{Utils.GetCurrentTime()}] - ", Color.LightGreen);
            richTextBoxInputCheck.AppendText($"Selected items deleted successfully.\r\n", Color.Magenta);
        }
    }

    public static class Utils
    {
        public static string GetCurrentTime()
        {
            var now = DateTime.UtcNow;

            var year = now.Year;
            var month = now.Month;
            var day = now.Day;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;
            var millisecond = now.Millisecond;

            return $"{year:0000}-{month:00}-{day:00} {hour:00}:{minute:00}:{second:00}.{millisecond:000}";
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

}
