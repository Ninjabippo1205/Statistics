using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Data;
using System.Globalization;

namespace HW4_Second_Part
{
    public partial class Form1 : Form
    {

        private TextBox[] inputTextBoxes;

        private TableLayoutPanel tableLayoutPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private async void submit1_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> dataset = new List<Dictionary<string, string>>(); ;
            string[] headers;
            //Dictionary<int,  string> intervals = new Dictionary<int, string>();

            using (HttpClient client = new HttpClient())
            {
                string csvData = await client.GetStringAsync("https://raw.githubusercontent.com/Ninjabippo1205/Statistics/main/homeworks/homework2/Dataset.csv");

                string[] righe = csvData.Split('\n');
                headers = righe[0].Split(',');

                for (var i = 0; i < righe[0].Split(",").Count(); i++)
                {
                    headers.Append(righe[0].Split(",")[i]);
                }

                for (var i = 1; i < righe.Count(); i++)
                {
                    Dictionary<string, string> riga = new Dictionary<string, string>();
                    for (var j = 0; j < headers.Count(); j++)
                    {
                        riga[headers[j]] = righe[i].Split(",")[j];
                    }
                    dataset.Add(riga);
                }

                tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;
                inputTextBoxes = new TextBox[headers.Count()];

                for (var i = 0; i < headers.Count(); i++)
                {
                    var valore = righe[1].Split(",")[i];
                    if (int.TryParse(valore, out _) || double.TryParse(valore, out _) || decimal.TryParse(valore, out _) || long.TryParse(valore, out _))
                    {
                        Label label = new Label();
                        label.Text = "Chose the intervals number for variabile " + headers[i] + "\t\t";
                        label.Width = 800;
                        label.Height = 50;
                        tableLayoutPanel.Controls.Add(label);

                        TextBox textBox = new TextBox();
                        textBox.Name = headers[i];
                        textBox.Text = (i + 4).ToString();
                        inputTextBoxes[i] = textBox;
                        tableLayoutPanel.Controls.Add(textBox);
                    }
                }
                Button calculateButton = new Button();
                calculateButton.Text = "Calcola";
                calculateButton.Click += CalculateButton_Click;
                calculateButton.Width = 100;
                calculateButton.Height = 40;
                tableLayoutPanel.Controls.Add(calculateButton);

                Controls.Add(tableLayoutPanel);
            }

        }


        static void OrdineAlfabeticoCrescente(List<Dictionary<string, string>> arr, string key)
        {
            arr.Sort((a, b) => string.Compare(a[key], b[key]));
        }

        static void OrdineAlfabeticoDecrescente(List<Dictionary<string, string>> arr, string key)
        {
            arr.Sort((a, b) => string.Compare(b[key], a[key]));
        }

        static void OrdineNumericoCrescente(List<Dictionary<string, string>> arr, string key)
        {
            arr.Sort((a, b) => {
                if (double.TryParse(a[key], out double aVal) && double.TryParse(b[key], out double bVal))
                {
                    return aVal.CompareTo(bVal);
                }
                return 0; // Gestione degli errori o valori non convertibili
            });
        }


        static void OrdineNumericoDecrescente(List<Dictionary<string, string>> arr, string key)
        {
            
        }

        static double TrovaValoreMassimo(List<Dictionary<string, string>> arr, string key)
        {
            double max = double.MinValue;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (double.Parse(arr[i][key].Replace('.', ',')) > max)
                {
                    max = double.Parse(arr[i][key].Replace('.', ','));
                }
            }
            return max;
        }

        static double TrovaValoreMinimo(List<Dictionary<string, string>> arr, string key)
        {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (double.Parse(arr[i][key].Replace('.', ',')) < min)
                {
                    min = double.Parse(arr[i][key].Replace('.', ','));
                }
            }
            return min;
        }


        private async void CalculateButton_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> dataset = new List<Dictionary<string, string>>(); ;
            string[] headers;

            using (HttpClient client = new HttpClient())
            {
                string csvData = await client.GetStringAsync("https://raw.githubusercontent.com/Ninjabippo1205/Statistics/main/homeworks/homework2/Dataset.csv");

                string[] righe = csvData.Split('\n');
                headers = righe[0].Split(',');

                for (var i = 0; i < righe[0].Split(",").Count(); i++)
                {
                    headers.Append(righe[0].Split(",")[i]);
                }

                for (var i = 1; i < righe.Count(); i++)
                {
                    Dictionary<string, string> riga = new Dictionary<string, string>();
                    for (var j = 0; j < headers.Count(); j++)
                    {
                        riga[headers[j]] = righe[i].Split(",")[j];
                    }
                    dataset.Add(riga);
                }

                Dictionary<int, int> intervals = new Dictionary<int, int>();
                for (var i = 0; i < headers.Count(); i++)
                {
                    if (inputTextBoxes[i] != null)
                    {
                        intervals[i] = int.Parse(inputTextBoxes[i].Text);
                    }
                }

                Dictionary<string, List<string>> intervalli = new Dictionary<string, List<string>>();

                foreach (var chiave in intervals.Keys)
                {
                    List<string> tmp = new List<string>();

                    double max = TrovaValoreMassimo(dataset, headers[chiave]);
                    double min = TrovaValoreMinimo(dataset, headers[chiave]);
                    double step = (max - min) / intervals[chiave];

                    for (double j = min; j < max; j += step)
                    {
                        double inizio = j;
                        double fine = (inizio + step);
                        string intervallo = inizio + "-" + fine;
                        tmp.Add(intervallo);
                    }

                    intervalli.Add(chiave+"", tmp);
                }

                List<List<string>> intervalsDataset = new List<List<string>>();

                foreach (var chiave in intervalli.Keys)
                {

                    List<string> tmp = new List<string>();
                    double max = TrovaValoreMassimo(dataset, headers[int.Parse(chiave)]);
                    double min = TrovaValoreMinimo(dataset, headers[int.Parse(chiave)]);

                    for (int i = 0; i < righe.Length - 1; i++)
                    {
                        foreach (var intervallo in intervalli[chiave])
                        {
                            string[] intParts = intervallo.Split('-');
                            double inf = double.Parse(intParts[0].Replace('.', ','));
                            double sup = double.Parse(intParts[1].Replace('.', ','));
                            var valore = double.Parse(dataset[i][headers[int.Parse(chiave)]].Replace('.', ','));
                            if (valore >= inf && valore < sup)
                            {
                                tmp.Add($"{inf}-{sup}");
                                break;
                            }

                            if (sup == max && valore == max)
                            {
                                tmp.Add(intervallo);
                                break;
                            }
                        }
                    
                    }

                    intervalsDataset.Add(tmp);
                    
                }

                List<int> nonIntervals = new List<int>();

                for (int i = 0; i < headers.Length; i++)
                {
                    var valore = righe[1].Split(",")[i].Replace(".", ",");
                    if (!int.TryParse(valore, out _) && !double.TryParse(valore, out _) && !decimal.TryParse(valore, out _) && !long.TryParse(valore, out _))
                    {
                        nonIntervals.Add(i);
                    }
                }

                List<Dictionary<string, int>> countDataset = new List<Dictionary<string, int>>();

                for (int i = 0; i < nonIntervals.Count; i++)
                {
                    Dictionary<string, int> tmp = new Dictionary<string, int>();

                    for (int j = 1; j < righe.Length - 1; j++)
                    {
                        string value = dataset[j][headers[nonIntervals[i]]];

                        if (tmp.ContainsKey(value))
                        {
                            tmp[value] += 1;
                        }
                        else
                        {
                            tmp[value] = 1;
                        }
                    }

                    countDataset.Add(tmp);
                }

                int total_statistical_units = dataset.Count();

                //Inizio dataGridView1

                Dictionary<string, int> int1 = new Dictionary<string, int>();

                for (int i = 0; i < intervalsDataset[0].Count; i++)
                {
                    string value = intervalsDataset[0][i];

                    if (int1.ContainsKey(value))
                    {
                        int1[value] += 1;
                    }
                    else
                    {
                        int1[value] = 1;
                    }
                }

                foreach (var value in intervalli[0+""])
                {
                    if (!int1.ContainsKey(value))
                    {
                        int1[value] = 0;
                    }
                }

                List<string> intervalloOrdinato1 = int1.Keys.ToList();
                intervalloOrdinato1.Sort();

                dataGridView1.Columns.Add("Variable", "Variable");
                dataGridView1.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
                dataGridView1.Columns.Add("RelativeFrequency", "Relative Frequency");
                dataGridView1.Columns.Add("Percentage", "Percentage");
                foreach (string key in intervalloOrdinato1)
                {
                    double a = ((double)int1[key] / (double)total_statistical_units);
                    dataGridView1.Rows.Add(key, int1[key], a, a * 100);
                }
                //Fine dataGridView1
                //Inizio dataGridView2
                Dictionary<string, int> int2 = new Dictionary<string, int>();

                for (int i = 0; i < intervalsDataset[0].Count; i++)
                {
                    string value = intervalsDataset[1][i];

                    if (int2.ContainsKey(value))
                    {
                        int2[value] += 1;
                    }
                    else
                    {
                        int2[value] = 1;
                    }
                }

                foreach (var value in intervalli[1 + ""])
                {
                    if (!int2.ContainsKey(value))
                    {
                        int2[value] = 0;
                    }
                }

                List<string> intervalloOrdinato2 = int2.Keys.ToList();
                intervalloOrdinato2.Sort();

                dataGridView2.Columns.Add("Variable", "Variable");
                dataGridView2.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
                dataGridView2.Columns.Add("RelativeFrequency", "Relative Frequency");
                dataGridView2.Columns.Add("Percentage", "Percentage");
                foreach (string key in intervalloOrdinato2)
                {
                    double a = ((double)int2[key] / (double)total_statistical_units);
                    dataGridView2.Rows.Add(key, int2[key], a, a * 100);
                }
                //Fine dataGridView2
                //Inizio dataGridView3
                List<string> intervalloOrdinato3 = new List<string>(countDataset[0].Keys);
                intervalloOrdinato3.Sort();


                dataGridView3.Columns.Add("Variable", "Variable");
                dataGridView3.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
                dataGridView3.Columns.Add("RelativeFrequency", "Relative Frequency");
                dataGridView3.Columns.Add("Percentage", "Percentage");
                foreach (string key in intervalloOrdinato3)
                {
                    double a = ((double)countDataset[0][key] / (double)total_statistical_units);
                    dataGridView3.Rows.Add(key, countDataset[0][key], a, a * 100);
                }
                //Fine dataGridView3

            }
        }
    }
}
