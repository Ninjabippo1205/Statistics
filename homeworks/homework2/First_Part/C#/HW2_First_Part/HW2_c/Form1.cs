using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;

namespace HW2_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpenCSV_Click(this, EventArgs.Empty);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\filip\\OneDrive\\Desktop\\Statistics\\Homework 2\\Application\\C#\\Dataset.csv";
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        DataTable dataTable = new DataTable();
                        DataTable dataTable2 = new DataTable();
                        DataTable dataTable3 = new DataTable();
                        DataTable dataTable4 = new DataTable();
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView2.RowHeadersVisible = false;
                        dataGridView3.RowHeadersVisible = false;
                        dataGridView4.RowHeadersVisible = false;

                        //Inizio tabella 1
                        string[] headers = reader.ReadLine().Split(',');
                        dataTable.Columns.Add("Variable");
                        dataTable.Columns.Add("Absolute frequence");
                        dataTable.Columns.Add("Relative frequence");
                        dataTable.Columns.Add("Percentage");

                        dataTable2.Columns.Add("Variable");
                        dataTable2.Columns.Add("Absolute frequence");
                        dataTable2.Columns.Add("Relative frequence");
                        dataTable2.Columns.Add("Percentage");

                        dataTable3.Columns.Add("Variable");
                        dataTable3.Columns.Add("Absolute frequence");
                        dataTable3.Columns.Add("Relative frequence");
                        dataTable3.Columns.Add("Percentage");

                        dataTable4.Columns.Add("Variable 1");
                        dataTable4.Columns.Add("Variable 2");
                        dataTable4.Columns.Add("Absolute frequence");
                        dataTable4.Columns.Add("Relative frequence");
                        dataTable4.Columns.Add("Percentage");

                        List<int> Enterpreneurial_attitude = new List<int>();
                        List<float> Weight = new List<float>();
                        List<string> Hobbies = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            string[] row = reader.ReadLine().Split(',');
                            Enterpreneurial_attitude.Add(int.Parse(row[0]));
                            Weight.Add(float.Parse(row[1]) / 10);
                            Hobbies.Add(row[2]);
                        }

                        var Enterpreneurial_attitude_arr = Enterpreneurial_attitude.GroupBy(x => x)
                            .Select(group => new Tuple<int, int>(group.Key, group.Count()))
                            .ToList();

                        foreach (var tuple in Enterpreneurial_attitude_arr)
                        {
                            float len = Convert.ToSingle(tuple.Item2) / Enterpreneurial_attitude.Count;
                            dataTable.Rows.Add(tuple.Item1, tuple.Item2, len, len * 100);
                        }
                        //Fine tabella 1

                        //Inizio tabella 2
                        
                        var Weight_arr = Weight.GroupBy(x => x)
                            .Select(group => new Tuple<float, int>(group.Key, group.Count()))
                            .ToList();

                        List<float> inter = new List<float>();
                        foreach (var tuple in Weight_arr)
                        {
                            inter.Add((float)(tuple.Item1));
                        }
                        float min = inter.Min();
                        float max = inter.Max();
                        
                        Dictionary<string, int> intervals = new Dictionary<string, int>();
                        for (int i = (int)min - 6; i < (int)max; i++)
                        {
                            if (i % 5 == 0)
                            {
                                intervals[i + "-" + (int)(i+5)] = 0;
                            }
                        }

                        foreach (var tupla in intervals)
                        {
                            int inf = Convert.ToInt16(tupla.Key.Split("-")[0]);
                            int sup = Convert.ToInt16(tupla.Key.Split("-")[1]);
                            
                            foreach (var coppia in Weight_arr)
                            {
                                if (coppia.Item1 >= inf && coppia.Item1 < sup)
                                {
                                    intervals[tupla.Key] += coppia.Item2;
                                }
                            }
                        }
                        
                        foreach (var tuple in intervals)
                        {
                            float len = Convert.ToSingle(tuple.Value) / Weight_arr.Count;
                            dataTable2.Rows.Add(tuple.Key, tuple.Value, len, len * 100);
                        }
                        
                        //Fine tabella 2

                        //Inizio tabella 3
                        var Hobbies_arr = Hobbies.GroupBy(x => x)
                            .Select(group => new Tuple<string, int>(group.Key, group.Count()))
                            .ToList();

                        foreach (var tuple in Hobbies_arr)
                        {
                            float len = Convert.ToSingle(tuple.Item2) / Weight_arr.Count;
                            dataTable3.Rows.Add(tuple.Item1, tuple.Item2, len, len * 100);
                        }
                        //Fine tabella 3

                        //Inizio tabella 4
                        Dictionary<Tuple<int, string>, int> jointDistribution = new Dictionary<Tuple<int, string>, int>();

                        foreach (var tuple in Enterpreneurial_attitude_arr)
                        {
                            foreach (var tuple2 in Hobbies_arr)
                            {
                                if (!jointDistribution.ContainsKey(Tuple.Create(tuple.Item1, tuple2.Item1)))
                                {
                                    Tuple<int, string> coppia = Tuple.Create(tuple.Item1, tuple2.Item1);
                                    jointDistribution[coppia] = 0;
                                }
                            }
                        }
                        
                        for (int i = 0; i < Enterpreneurial_attitude.Count; i++)
                        {
                            Tuple<int, string> coppia = Tuple.Create(Enterpreneurial_attitude[i], Hobbies[i]);
                            if (jointDistribution.ContainsKey(coppia))
                            {
                                jointDistribution[coppia]++;
                            }
                        }
                        
                        foreach (var tupla in jointDistribution)
                        {
                            var coppia = tupla.Key;
                            float len = Convert.ToSingle(tupla.Value) / Enterpreneurial_attitude.Count;
                            if (tupla.Value > 0)
                            {
                                dataTable4.Rows.Add(coppia.Item1, coppia.Item2, tupla.Value, len, len * 100);
                            }
                        }
                        //Fine tabella 4

                        dataGridView1.DataSource = dataTable;
                        dataGridView2.DataSource = dataTable2;
                        dataGridView3.DataSource = dataTable3;
                        dataGridView4.DataSource = dataTable4;
                    }
                }
                else
                {
                    MessageBox.Show("Il file specificato non esiste.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la lettura del file: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}