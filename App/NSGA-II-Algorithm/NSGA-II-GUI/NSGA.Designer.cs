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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.richTextBoxInputCheck = new System.Windows.Forms.RichTextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnDefaultData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxGen = new System.Windows.Forms.Label();
            this.textBoxMutation = new System.Windows.Forms.TextBox();
            this.lblMutation = new System.Windows.Forms.Label();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.textBoxCrossover = new System.Windows.Forms.TextBox();
            this.textBoxPopSize = new System.Windows.Forms.TextBox();
            this.lblCrossover = new System.Windows.Forms.Label();
            this.lblPopSize = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 1048);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.richTextBoxInputCheck);
            this.tabInput.Controls.Add(this.dataGrid);
            this.tabInput.Controls.Add(this.btnResetData);
            this.tabInput.Controls.Add(this.btnDefaultData);
            this.tabInput.Controls.Add(this.groupBox1);
            this.tabInput.Controls.Add(this.btnStart);
            this.tabInput.Controls.Add(this.btnDeleteSelected);
            this.tabInput.Location = new System.Drawing.Point(4, 25);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(1171, 1019);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // richTextBoxInputCheck
            // 
            this.richTextBoxInputCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInputCheck.Location = new System.Drawing.Point(21, 795);
            this.richTextBoxInputCheck.Name = "richTextBoxInputCheck";
            this.richTextBoxInputCheck.Size = new System.Drawing.Size(1136, 138);
            this.richTextBoxInputCheck.TabIndex = 14;
            this.richTextBoxInputCheck.Text = "";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid.ColumnHeadersHeight = 29;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.TableWeight,
            this.TableCost,
            this.TableTime});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid.Location = new System.Drawing.Point(21, 145);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1136, 644);
            this.dataGrid.TabIndex = 13;
            // 
            // TableName
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableName.DefaultCellStyle = dataGridViewCellStyle8;
            this.TableName.HeaderText = "Name";
            this.TableName.MinimumWidth = 6;
            this.TableName.Name = "TableName";
            // 
            // TableWeight
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableWeight.DefaultCellStyle = dataGridViewCellStyle9;
            this.TableWeight.HeaderText = "Weight";
            this.TableWeight.MinimumWidth = 6;
            this.TableWeight.Name = "TableWeight";
            // 
            // TableCost
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableCost.DefaultCellStyle = dataGridViewCellStyle10;
            this.TableCost.HeaderText = "Cost";
            this.TableCost.MinimumWidth = 6;
            this.TableCost.Name = "TableCost";
            // 
            // TableTime
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableTime.DefaultCellStyle = dataGridViewCellStyle11;
            this.TableTime.HeaderText = "Loot Time";
            this.TableTime.MinimumWidth = 6;
            this.TableTime.Name = "TableTime";
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(157, 949);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(205, 53);
            this.btnResetData.TabIndex = 12;
            this.btnResetData.Text = "Reset Data";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnDefaultData
            // 
            this.btnDefaultData.Location = new System.Drawing.Point(368, 949);
            this.btnDefaultData.Name = "btnDefaultData";
            this.btnDefaultData.Size = new System.Drawing.Size(205, 53);
            this.btnDefaultData.TabIndex = 11;
            this.btnDefaultData.Text = "Load Default Data";
            this.btnDefaultData.UseVisualStyleBackColor = true;
            this.btnDefaultData.Click += new System.EventHandler(this.btnDefaultData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxGen);
            this.groupBox1.Controls.Add(this.textBoxMutation);
            this.groupBox1.Controls.Add(this.lblMutation);
            this.groupBox1.Controls.Add(this.textBoxMaxGen);
            this.groupBox1.Controls.Add(this.textBoxCrossover);
            this.groupBox1.Controls.Add(this.textBoxPopSize);
            this.groupBox1.Controls.Add(this.lblCrossover);
            this.groupBox1.Controls.Add(this.lblPopSize);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Parameters";
            // 
            // lblMaxGen
            // 
            this.lblMaxGen.AutoSize = true;
            this.lblMaxGen.Location = new System.Drawing.Point(35, 20);
            this.lblMaxGen.Name = "lblMaxGen";
            this.lblMaxGen.Size = new System.Drawing.Size(119, 17);
            this.lblMaxGen.TabIndex = 2;
            this.lblMaxGen.Text = "Max Generations:";
            // 
            // textBoxMutation
            // 
            this.textBoxMutation.Location = new System.Drawing.Point(1007, 38);
            this.textBoxMutation.Name = "textBoxMutation";
            this.textBoxMutation.Size = new System.Drawing.Size(100, 22);
            this.textBoxMutation.TabIndex = 9;
            this.textBoxMutation.Text = "0.02";
            this.textBoxMutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMutation
            // 
            this.lblMutation.AutoSize = true;
            this.lblMutation.Location = new System.Drawing.Point(1023, 18);
            this.lblMutation.Name = "lblMutation";
            this.lblMutation.Size = new System.Drawing.Size(66, 17);
            this.lblMutation.TabIndex = 5;
            this.lblMutation.Text = "Mutation:";
            // 
            // textBoxMaxGen
            // 
            this.textBoxMaxGen.Location = new System.Drawing.Point(41, 40);
            this.textBoxMaxGen.Name = "textBoxMaxGen";
            this.textBoxMaxGen.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxGen.TabIndex = 6;
            this.textBoxMaxGen.Text = "1";
            this.textBoxMaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCrossover
            // 
            this.textBoxCrossover.Location = new System.Drawing.Point(716, 40);
            this.textBoxCrossover.Name = "textBoxCrossover";
            this.textBoxCrossover.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrossover.TabIndex = 8;
            this.textBoxCrossover.Text = "0.9";
            this.textBoxCrossover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPopSize
            // 
            this.textBoxPopSize.Location = new System.Drawing.Point(358, 40);
            this.textBoxPopSize.Name = "textBoxPopSize";
            this.textBoxPopSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxPopSize.TabIndex = 7;
            this.textBoxPopSize.Text = "1";
            this.textBoxPopSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCrossover
            // 
            this.lblCrossover.AutoSize = true;
            this.lblCrossover.Location = new System.Drawing.Point(727, 20);
            this.lblCrossover.Name = "lblCrossover";
            this.lblCrossover.Size = new System.Drawing.Size(76, 17);
            this.lblCrossover.TabIndex = 4;
            this.lblCrossover.Text = "Crossover:";
            // 
            // lblPopSize
            // 
            this.lblPopSize.AutoSize = true;
            this.lblPopSize.Location = new System.Drawing.Point(352, 20);
            this.lblPopSize.Name = "lblPopSize";
            this.lblPopSize.Size = new System.Drawing.Size(110, 17);
            this.lblPopSize.TabIndex = 3;
            this.lblPopSize.Text = "Population Size:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(803, 949);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(579, 949);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(218, 53);
            this.btnDeleteSelected.TabIndex = 0;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tabGraphs
            // 
            this.tabGraphs.Controls.Add(this.groupBox2);
            this.tabGraphs.Controls.Add(this.groupBoxChromosomeInfo);
            this.tabGraphs.Controls.Add(this.NSGAChart);
            this.tabGraphs.Location = new System.Drawing.Point(4, 25);
            this.tabGraphs.Name = "tabGraphs";
            this.tabGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphs.Size = new System.Drawing.Size(1171, 1019);
            this.tabGraphs.TabIndex = 1;
            this.tabGraphs.Text = "Output";
            this.tabGraphs.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMaxWeightFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxMaxWeight);
            this.groupBox2.Location = new System.Drawing.Point(8, 718);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1132, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By Weight";
            // 
            // buttonMaxWeightFilter
            // 
            this.buttonMaxWeightFilter.Location = new System.Drawing.Point(590, 27);
            this.buttonMaxWeightFilter.Name = "buttonMaxWeightFilter";
            this.buttonMaxWeightFilter.Size = new System.Drawing.Size(524, 39);
            this.buttonMaxWeightFilter.TabIndex = 2;
            this.buttonMaxWeightFilter.Text = "Filter";
            this.buttonMaxWeightFilter.UseVisualStyleBackColor = true;
            this.buttonMaxWeightFilter.Click += new System.EventHandler(this.buttonMaxWeightFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Weight";
            // 
            // textBoxMaxWeight
            // 
            this.textBoxMaxWeight.Location = new System.Drawing.Point(247, 35);
            this.textBoxMaxWeight.Name = "textBoxMaxWeight";
            this.textBoxMaxWeight.Size = new System.Drawing.Size(208, 22);
            this.textBoxMaxWeight.TabIndex = 0;
            this.textBoxMaxWeight.Text = "100";
            // 
            // groupBoxChromosomeInfo
            // 
            this.groupBoxChromosomeInfo.Controls.Add(this.richTextBoxLootedItems);
            this.groupBoxChromosomeInfo.Controls.Add(this.richTextBoxGraph);
            this.groupBoxChromosomeInfo.Location = new System.Drawing.Point(0, 806);
            this.groupBoxChromosomeInfo.Name = "groupBoxChromosomeInfo";
            this.groupBoxChromosomeInfo.Size = new System.Drawing.Size(1165, 205);
            this.groupBoxChromosomeInfo.TabIndex = 2;
            this.groupBoxChromosomeInfo.TabStop = false;
            this.groupBoxChromosomeInfo.Text = "Chromosome Information";
            // 
            // richTextBoxLootedItems
            // 
            this.richTextBoxLootedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLootedItems.Location = new System.Drawing.Point(664, 21);
            this.richTextBoxLootedItems.Name = "richTextBoxLootedItems";
            this.richTextBoxLootedItems.Size = new System.Drawing.Size(495, 182);
            this.richTextBoxLootedItems.TabIndex = 2;
            this.richTextBoxLootedItems.Text = "";
            // 
            // richTextBoxGraph
            // 
            this.richTextBoxGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGraph.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxGraph.Name = "richTextBoxGraph";
            this.richTextBoxGraph.Size = new System.Drawing.Size(652, 182);
            this.richTextBoxGraph.TabIndex = 1;
            this.richTextBoxGraph.Text = "";
            // 
            // NSGAChart
            // 
            this.NSGAChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.NSGAChart.Location = new System.Drawing.Point(3, 3);
            this.NSGAChart.Name = "NSGAChart";
            this.NSGAChart.Size = new System.Drawing.Size(1165, 693);
            this.NSGAChart.TabIndex = 0;
            this.NSGAChart.Text = "NSGAChart";
            // 
            // NSGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 1048);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NSGA";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NSGA-II";
            this.tabControl1.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
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
    }
}

