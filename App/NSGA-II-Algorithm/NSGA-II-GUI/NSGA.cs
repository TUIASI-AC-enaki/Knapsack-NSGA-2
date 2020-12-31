using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSGA_II_Algorithm.models;

namespace NSGA_II_GUI
{
    public partial class NSGA : Form
    {
        public NSGA()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try{

                var maxGenerations = Double.Parse(textBoxMaxGen.Text, CultureInfo.InvariantCulture);
                var populationSize = Double.Parse(textBoxPopSize.Text, CultureInfo.InvariantCulture);
                var crossoverProbability = Double.Parse(textBoxCrossover.Text, CultureInfo.InvariantCulture);
                var mutationProbability = Double.Parse(textBoxMutation.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {

            }

        }


        private void btnDefaultData_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();
            textBoxMaxGen.Text = "1";
            textBoxPopSize.Text = "10";
            textBoxCrossover.Text = "0.02";
            textBoxMutation.Text = "0.9";

            var items = GetDefaultItems();
            foreach(var item in items)
            {
                AddTableItem(item.Name, item.Weight.ToString(CultureInfo.InvariantCulture),
                    item.Price.ToString(CultureInfo.InvariantCulture),
                    item.TimeRequired.ToString(CultureInfo.InvariantCulture));
            }
        }

        private void AddTableItem(String name, String weight, String price, String time)
        {
            DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
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
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                if (row.Index+1 != dataGrid.Rows.Count)
                {
                    dataGrid.Rows.RemoveAt(row.Index);
                }
                
            }
        }


        static List<Item> GetDefaultItems()
        {
            var list = new List<Item>
            {
                new Item("Lantisor de aur", 0.7, 500, 1),
                new Item("Unicorn", 100, 300, 2),
                new Item("Caldare", 2, 30, 30),
                new Item("Mar", 0.2, 3, 3),
                new Item("Sticla", 0.7, 4, 4),
                new Item("Telefon",70,500,2.5),
                new Item("Banane",0.2,2,3),
                new Item("Parfum",0.4,50,4),
                new Item("Acumulator",0.6,250,7),
                new Item("Televizor",10,800,40),
                new Item("Lanterna",0.2,30,2.2),
                new Item("Calculator",10,2400,70),
                new Item("Portofel cu bani",0.1,300,5),
                new Item("Elicopter RC",0.5,700,20),
                new Item("MASA DE TENIS",20,640,100),
                new Item("Biscuiti Oreo", 0.5, 5, 5)

            };
            return list;
        }
    }
}
