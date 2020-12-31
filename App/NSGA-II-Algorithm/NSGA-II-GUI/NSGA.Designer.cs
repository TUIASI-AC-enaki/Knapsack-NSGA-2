namespace NSGA_II_GUI
{
    partial class NSGA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.groupBoxConsoleLogger = new System.Windows.Forms.GroupBox();
            this.richTextBoxInputCheck = new System.Windows.Forms.RichTextBox();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnDefaultData = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxGen = new System.Windows.Forms.Label();
            this.textBoxMutation = new System.Windows.Forms.TextBox();
            this.lblMutation = new System.Windows.Forms.Label();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxCrossover = new System.Windows.Forms.TextBox();
            this.textBoxPopSize = new System.Windows.Forms.TextBox();
            this.lblCrossover = new System.Windows.Forms.Label();
            this.lblPopSize = new System.Windows.Forms.Label();
            this.tabGraphs = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMaxWeightFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxWeight = new System.Windows.Forms.TextBox();
            this.groupBoxChromosomeInfo = new System.Windows.Forms.GroupBox();
            this.richTextBoxLootedItems = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGraph = new System.Windows.Forms.RichTextBox();
            this.NSGAChart = new LiveCharts.WinForms.CartesianChart();
            this.tabControl1.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.groupBoxConsoleLogger.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabGraphs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxChromosomeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabGraphs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 922);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.groupBoxConsoleLogger);
            this.tabInput.Controls.Add(this.groupBoxItems);
            this.tabInput.Controls.Add(this.groupBox1);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Margin = new System.Windows.Forms.Padding(2);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(2);
            this.tabInput.Size = new System.Drawing.Size(876, 896);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsoleLogger
            // 
            this.groupBoxConsoleLogger.Controls.Add(this.richTextBoxInputCheck);
            this.groupBoxConsoleLogger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBoxConsoleLogger.ForeColor = System.Drawing.Color.Green;
            this.groupBoxConsoleLogger.Location = new System.Drawing.Point(16, 627);
            this.groupBoxConsoleLogger.Name = "groupBoxConsoleLogger";
            this.groupBoxConsoleLogger.Size = new System.Drawing.Size(855, 261);
            this.groupBoxConsoleLogger.TabIndex = 14;
            this.groupBoxConsoleLogger.TabStop = false;
            this.groupBoxConsoleLogger.Text = "Console Logger";
            // 
            // richTextBoxInputCheck
            // 
            this.richTextBoxInputCheck.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxInputCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInputCheck.ForeColor = System.Drawing.Color.Yellow;
            this.richTextBoxInputCheck.Location = new System.Drawing.Point(11, 18);
            this.richTextBoxInputCheck.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxInputCheck.Name = "richTextBoxInputCheck";
            this.richTextBoxInputCheck.Size = new System.Drawing.Size(836, 238);
            this.richTextBoxInputCheck.TabIndex = 14;
            this.richTextBoxInputCheck.Text = "";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.dataGrid);
            this.groupBoxItems.Controls.Add(this.btnResetData);
            this.groupBoxItems.Controls.Add(this.btnDefaultData);
            this.groupBoxItems.Controls.Add(this.btnDeleteSelected);
            this.groupBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBoxItems.ForeColor = System.Drawing.Color.Coral;
            this.groupBoxItems.Location = new System.Drawing.Point(16, 92);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(852, 519);
            this.groupBoxItems.TabIndex = 15;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeight = 29;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.TableWeight,
            this.TableCost,
            this.TableTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.Location = new System.Drawing.Point(4, 18);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(843, 433);
            this.dataGrid.TabIndex = 13;
            // 
            // TableName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableName.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableName.HeaderText = "Name";
            this.TableName.MinimumWidth = 6;
            this.TableName.Name = "TableName";
            // 
            // TableWeight
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableWeight.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableWeight.HeaderText = "Weight";
            this.TableWeight.MinimumWidth = 6;
            this.TableWeight.Name = "TableWeight";
            // 
            // TableCost
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.TableCost.HeaderText = "Cost";
            this.TableCost.MinimumWidth = 6;
            this.TableCost.Name = "TableCost";
            // 
            // TableTime
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.TableTime.HeaderText = "Loot Time";
            this.TableTime.MinimumWidth = 6;
            this.TableTime.Name = "TableTime";
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(124, 464);
            this.btnResetData.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(154, 43);
            this.btnResetData.TabIndex = 12;
            this.btnResetData.Text = "Reset Data";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnDefaultData
            // 
            this.btnDefaultData.Location = new System.Drawing.Point(380, 464);
            this.btnDefaultData.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaultData.Name = "btnDefaultData";
            this.btnDefaultData.Size = new System.Drawing.Size(154, 43);
            this.btnDefaultData.TabIndex = 11;
            this.btnDefaultData.Text = "Load Default Data";
            this.btnDefaultData.UseVisualStyleBackColor = true;
            this.btnDefaultData.Click += new System.EventHandler(this.btnDefaultData_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(613, 464);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(164, 43);
            this.btnDeleteSelected.TabIndex = 0;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxGen);
            this.groupBox1.Controls.Add(this.textBoxMutation);
            this.groupBox1.Controls.Add(this.lblMutation);
            this.groupBox1.Controls.Add(this.textBoxMaxGen);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.textBoxCrossover);
            this.groupBox1.Controls.Add(this.textBoxPopSize);
            this.groupBox1.Controls.Add(this.lblCrossover);
            this.groupBox1.Controls.Add(this.lblPopSize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(852, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Parameters";
            // 
            // lblMaxGen
            // 
            this.lblMaxGen.AutoSize = true;
            this.lblMaxGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMaxGen.ForeColor = System.Drawing.Color.Blue;
            this.lblMaxGen.Location = new System.Drawing.Point(26, 16);
            this.lblMaxGen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxGen.Name = "lblMaxGen";
            this.lblMaxGen.Size = new System.Drawing.Size(90, 13);
            this.lblMaxGen.TabIndex = 2;
            this.lblMaxGen.Text = "Max Generations:";
            // 
            // textBoxMutation
            // 
            this.textBoxMutation.Location = new System.Drawing.Point(477, 35);
            this.textBoxMutation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMutation.Name = "textBoxMutation";
            this.textBoxMutation.Size = new System.Drawing.Size(76, 20);
            this.textBoxMutation.TabIndex = 9;
            this.textBoxMutation.Text = "0.02";
            this.textBoxMutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMutation
            // 
            this.lblMutation.AutoSize = true;
            this.lblMutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMutation.ForeColor = System.Drawing.Color.Blue;
            this.lblMutation.Location = new System.Drawing.Point(483, 16);
            this.lblMutation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMutation.Name = "lblMutation";
            this.lblMutation.Size = new System.Drawing.Size(51, 13);
            this.lblMutation.TabIndex = 5;
            this.lblMutation.Text = "Mutation:";
            // 
            // textBoxMaxGen
            // 
            this.textBoxMaxGen.Location = new System.Drawing.Point(31, 35);
            this.textBoxMaxGen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxGen.Name = "textBoxMaxGen";
            this.textBoxMaxGen.Size = new System.Drawing.Size(76, 20);
            this.textBoxMaxGen.TabIndex = 6;
            this.textBoxMaxGen.Text = "1";
            this.textBoxMaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(641, 15);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBoxCrossover
            // 
            this.textBoxCrossover.Location = new System.Drawing.Point(330, 35);
            this.textBoxCrossover.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCrossover.Name = "textBoxCrossover";
            this.textBoxCrossover.Size = new System.Drawing.Size(76, 20);
            this.textBoxCrossover.TabIndex = 8;
            this.textBoxCrossover.Text = "0.9";
            this.textBoxCrossover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPopSize
            // 
            this.textBoxPopSize.Location = new System.Drawing.Point(170, 35);
            this.textBoxPopSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPopSize.Name = "textBoxPopSize";
            this.textBoxPopSize.Size = new System.Drawing.Size(76, 20);
            this.textBoxPopSize.TabIndex = 7;
            this.textBoxPopSize.Text = "1";
            this.textBoxPopSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCrossover
            // 
            this.lblCrossover.AutoSize = true;
            this.lblCrossover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCrossover.ForeColor = System.Drawing.Color.Blue;
            this.lblCrossover.Location = new System.Drawing.Point(338, 16);
            this.lblCrossover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrossover.Name = "lblCrossover";
            this.lblCrossover.Size = new System.Drawing.Size(57, 13);
            this.lblCrossover.TabIndex = 4;
            this.lblCrossover.Text = "Crossover:";
            // 
            // lblPopSize
            // 
            this.lblPopSize.AutoSize = true;
            this.lblPopSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPopSize.ForeColor = System.Drawing.Color.Blue;
            this.lblPopSize.Location = new System.Drawing.Point(167, 15);
            this.lblPopSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPopSize.Name = "lblPopSize";
            this.lblPopSize.Size = new System.Drawing.Size(83, 13);
            this.lblPopSize.TabIndex = 3;
            this.lblPopSize.Text = "Population Size:";
            // 
            // tabGraphs
            // 
            this.tabGraphs.Controls.Add(this.groupBox2);
            this.tabGraphs.Controls.Add(this.groupBoxChromosomeInfo);
            this.tabGraphs.Controls.Add(this.NSGAChart);
            this.tabGraphs.Location = new System.Drawing.Point(4, 22);
            this.tabGraphs.Margin = new System.Windows.Forms.Padding(2);
            this.tabGraphs.Name = "tabGraphs";
            this.tabGraphs.Padding = new System.Windows.Forms.Padding(2);
            this.tabGraphs.Size = new System.Drawing.Size(876, 896);
            this.tabGraphs.TabIndex = 1;
            this.tabGraphs.Text = "Output";
            this.tabGraphs.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMaxWeightFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxMaxWeight);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(6, 583);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(849, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By Weight";
            // 
            // buttonMaxWeightFilter
            // 
            this.buttonMaxWeightFilter.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonMaxWeightFilter.Location = new System.Drawing.Point(442, 22);
            this.buttonMaxWeightFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaxWeightFilter.Name = "buttonMaxWeightFilter";
            this.buttonMaxWeightFilter.Size = new System.Drawing.Size(393, 32);
            this.buttonMaxWeightFilter.TabIndex = 2;
            this.buttonMaxWeightFilter.Text = "Filter";
            this.buttonMaxWeightFilter.UseVisualStyleBackColor = true;
            this.buttonMaxWeightFilter.Click += new System.EventHandler(this.buttonMaxWeightFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Weight";
            // 
            // textBoxMaxWeight
            // 
            this.textBoxMaxWeight.Location = new System.Drawing.Point(178, 28);
            this.textBoxMaxWeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxWeight.Name = "textBoxMaxWeight";
            this.textBoxMaxWeight.Size = new System.Drawing.Size(141, 20);
            this.textBoxMaxWeight.TabIndex = 0;
            this.textBoxMaxWeight.Text = "100";
            this.textBoxMaxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxChromosomeInfo
            // 
            this.groupBoxChromosomeInfo.Controls.Add(this.richTextBoxLootedItems);
            this.groupBoxChromosomeInfo.Controls.Add(this.richTextBoxGraph);
            this.groupBoxChromosomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBoxChromosomeInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxChromosomeInfo.Location = new System.Drawing.Point(0, 655);
            this.groupBoxChromosomeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChromosomeInfo.Name = "groupBoxChromosomeInfo";
            this.groupBoxChromosomeInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChromosomeInfo.Size = new System.Drawing.Size(874, 239);
            this.groupBoxChromosomeInfo.TabIndex = 2;
            this.groupBoxChromosomeInfo.TabStop = false;
            this.groupBoxChromosomeInfo.Text = "Chromosome Information";
            // 
            // richTextBoxLootedItems
            // 
            this.richTextBoxLootedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLootedItems.Location = new System.Drawing.Point(461, 17);
            this.richTextBoxLootedItems.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxLootedItems.Name = "richTextBoxLootedItems";
            this.richTextBoxLootedItems.Size = new System.Drawing.Size(409, 217);
            this.richTextBoxLootedItems.TabIndex = 2;
            this.richTextBoxLootedItems.Text = "";
            // 
            // richTextBoxGraph
            // 
            this.richTextBoxGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGraph.Location = new System.Drawing.Point(4, 17);
            this.richTextBoxGraph.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxGraph.Name = "richTextBoxGraph";
            this.richTextBoxGraph.Size = new System.Drawing.Size(453, 217);
            this.richTextBoxGraph.TabIndex = 1;
            this.richTextBoxGraph.Text = "";
            // 
            // NSGAChart
            // 
            this.NSGAChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.NSGAChart.Location = new System.Drawing.Point(2, 2);
            this.NSGAChart.Margin = new System.Windows.Forms.Padding(2);
            this.NSGAChart.Name = "NSGAChart";
            this.NSGAChart.Size = new System.Drawing.Size(872, 563);
            this.NSGAChart.TabIndex = 0;
            this.NSGAChart.Text = "NSGAChart";
            // 
            // NSGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 922);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NSGA";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NSGA-II";
            this.tabControl1.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.groupBoxConsoleLogger.ResumeLayout(false);
            this.groupBoxItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGraphs.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxChromosomeInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.Label lblPopSize;
        private System.Windows.Forms.Label lblMaxGen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCrossover;
        private System.Windows.Forms.Label lblMutation;
        private System.Windows.Forms.TextBox textBoxPopSize;
        private System.Windows.Forms.TextBox textBoxMaxGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMutation;
        private System.Windows.Forms.TextBox textBoxCrossover;
        private System.Windows.Forms.Button btnDefaultData;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.TabPage tabGraphs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableTime;
        private LiveCharts.WinForms.CartesianChart NSGAChart;
        private System.Windows.Forms.RichTextBox richTextBoxInputCheck;
        private System.Windows.Forms.RichTextBox richTextBoxGraph;
        private System.Windows.Forms.GroupBox groupBoxChromosomeInfo;
        private System.Windows.Forms.RichTextBox richTextBoxLootedItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMaxWeightFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxWeight;
        private System.Windows.Forms.GroupBox groupBoxConsoleLogger;
        private System.Windows.Forms.GroupBox groupBoxItems;
    }
}

