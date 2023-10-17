using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW2_Third_Part
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int N, k;
            if (int.TryParse(random_variatesTextBox.Text, out N) && int.TryParse(intervalsTextBox.Text, out k))
            {
                Random random = new Random();
                List<double> randomNumbers = new List<double>();

                for (int i = 0; i < N; i++)
                {
                    double randomNumber = Math.Round(random.NextDouble(), 2);
                    randomNumbers.Add(randomNumber);
                }

                double[] intervals = new double[k];
                Dictionary<int, List<double>> dictionary = new Dictionary<int, List<double>>();

                for (int i = 0; i < k; i++)
                {
                    intervals[i] = (double)i / k;
                    dictionary[i] = new List<double>();
                }

                foreach (double number in randomNumbers)
                {
                    for (int j = 0; j < k; j++)
                    {
                        if (number >= intervals[j] && number < intervals[j] + 1.0 / k)
                        {
                            dictionary[j].Add(number);
                            break;
                        }
                    }
                }

                resultTable.RowHeadersVisible = false;
                resultTable.AllowUserToAddRows = false;

                resultTable.ScrollBars = ScrollBars.Both;

                resultTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                resultTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                resultTable.Rows.Clear();
                resultTable.Columns.Clear();
                resultTable.Columns.Add("Interval", "Interval");
                resultTable.Columns.Add("Count", "Count");
                resultTable.Columns.Add("Values", "Values");
                resultTable.Columns["Values"].Width = 500;

                List<string> interv = new List<string>();

                foreach (int key in dictionary.Keys)
                {
                    resultTable.Rows.Add("Intervallo " + key * (1.0 / k) + " - " + (key + 1) * (1.0 / k), dictionary[key].Count, string.Join("  ,  ", dictionary[key]));
                    interv.Add(key * (1.0 / k) + " - " + (key + 1) * (1.0 / k));
                }

                List<int> columnHeights = new List<int>();

                foreach (var i in interv)
                {
                    int key = Array.IndexOf(interv.ToArray(), i);

                    if (dictionary.ContainsKey(key))
                    {
                        columnHeights.Add(dictionary[key].Count);
                    }
                    else
                    {
                        columnHeights.Add(0);
                    }
                }

                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
                double intervalWidth = 1.0 / k;
                double labelShift = 0.5;
                for (int i = 0; i < interv.Count; i++)
                {

                    string seriesName = interv[i];
                    chart1.Series.Add(seriesName);
                    chart1.Series[seriesName].Points.AddXY("", columnHeights[i]);
                    chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.Black;

                    int maxValue = columnHeights.Max();
                    chart1.ChartAreas[0].AxisY.Maximum = maxValue + (int)Math.Pow(10, (int)Math.Log10(maxValue));
                    chart1.Series[seriesName].IsValueShownAsLabel = true;

                    double startX = i * intervalWidth - labelShift;
                    double endX = (i + 1) * intervalWidth - labelShift;
                    CustomLabel label = new CustomLabel(startX, endX, interv[i], 0, LabelMarkStyle.None);
                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(label);
                    chart1.Series[seriesName]["PointWidth"] = "1";
                }
            }
            else
            {
                MessageBox.Show("Inserisci numeri validi per N e k.");
            }
        }
    }
}
