namespace HW2_es3_bis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            resultTable = new DataGridView();
            label3 = new Label();
            calculate = new Button();
            label2 = new Label();
            label1 = new Label();
            intervalsTextBox = new TextBox();
            random_variatesTextBox = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)resultTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // resultTable
            // 
            resultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultTable.Location = new Point(955, 615);
            resultTable.Name = "resultTable";
            resultTable.RowHeadersWidth = 72;
            resultTable.Size = new Size(1539, 484);
            resultTable.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 56);
            label3.Name = "label3";
            label3.Size = new Size(611, 30);
            label3.TabIndex = 12;
            label3.Text = "Distribution of N random variates in [0,1) divided into k-1 classes";
            // 
            // calculate
            // 
            calculate.Location = new Point(652, 355);
            calculate.Name = "calculate";
            calculate.Size = new Size(131, 40);
            calculate.TabIndex = 11;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 247);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 10;
            label2.Text = "Insert the number of intervals (k):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 152);
            label1.Name = "label1";
            label1.Size = new Size(477, 30);
            label1.TabIndex = 9;
            label1.Text = "Insert the number of uniform random variates (N):";
            // 
            // intervalsTextBox
            // 
            intervalsTextBox.Location = new Point(652, 242);
            intervalsTextBox.Name = "intervalsTextBox";
            intervalsTextBox.Size = new Size(175, 35);
            intervalsTextBox.TabIndex = 8;
            // 
            // random_variatesTextBox
            // 
            random_variatesTextBox.Location = new Point(652, 149);
            random_variatesTextBox.Name = "random_variatesTextBox";
            random_variatesTextBox.Size = new Size(175, 35);
            random_variatesTextBox.TabIndex = 7;
            // 
            // chart1
            // 
            chart1.BackImageTransparentColor = Color.Black;
            chart1.BackSecondaryColor = Color.Black;
            chart1.BorderlineColor = Color.Black;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(955, 56);
            chart1.Name = "chart1";
            series1.BackSecondaryColor = Color.Black;
            series1.BorderColor = Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.YellowGreen;
            series1.LabelBackColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = Color.Black;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1539, 525);
            chart1.SuppressExceptions = true;
            chart1.TabIndex = 14;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2710, 1385);
            Controls.Add(chart1);
            Controls.Add(resultTable);
            Controls.Add(label3);
            Controls.Add(calculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(intervalsTextBox);
            Controls.Add(random_variatesTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)resultTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resultTable;
        private Label label3;
        private Button calculate;
        private Label label2;
        private Label label1;
        private TextBox intervalsTextBox;
        private TextBox random_variatesTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
