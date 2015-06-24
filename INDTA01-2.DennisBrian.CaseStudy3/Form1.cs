using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDTA01_2.DennisBrian.CaseStudy3
{
    public partial class Form1 : Form
    {
        private Dictionary<int, double> originalDataset = new Dictionary<int, double>();
        private string[] lines;

        public Form1()
        {
            InitializeComponent();

            lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "/" + "SESDES.csv");
            
            originalDataset = 
                lines.Select(line => line.Split(';'))
                    .TakeWhile(values => !values[1].Equals(""))
                    .ToDictionary(values => int.Parse(values[0]), values => double.Parse(values[1]));

            Plot(originalDataset, "Original");
        }

        private void Plot(Dictionary<int, double> resultSet, string series)
        {
            mainChart.Series[series].Points.Clear();
            mainChart.Series["SES"].Points.Clear();
            mainChart.Series["DES"].Points.Clear();
            foreach (KeyValuePair<int, double> pair in resultSet)
            {
                mainChart.Series[series].Points.AddXY(pair.Key, pair.Value);
            }
        }

        private void btnPlotAlpha_Click(object sender, EventArgs e)
        {
            Dictionary<int, double> result = new SesForecasting(originalDataset).Calculate(double.Parse(txtAlpha.Text));

            for (int i = result.Count; i < lines.Length; i++)
                result.Add(i + 1, result.Last().Value);

            Plot(result, "SES");
        }

        private void btnOptimal_Click(object sender, EventArgs e)
        {
            Tuple<double, double, Dictionary<int, double>> result =
                new SesForecasting(originalDataset, 0.01, 0.01).CalculateOptimal();

            lblAlpha.Text = "Optimal alpha: " + Math.Round(result.Item1, 2);
            lblStdError.Text = "Standard Error: " + Math.Round(result.Item2, 2);

            Plot(result.Item3, "SES");
        }

        private void btnPlotAlphaBeta_Click(object sender, EventArgs e)
        {
            Dictionary<int, double> result =
                new DesForecasting(originalDataset, 0.1, 0.1, lines.Length).CalculateDesPoints(double.Parse(txtAlphaDes.Text),
                    double.Parse(txtBetaDes.Text));

            Plot(result, "DES");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tuple<double, double, double, Dictionary<int, double>> result =
                new DesForecasting(originalDataset, 0.01, 0.01, lines.Length).CalculateOptimal();

            lblAlpha.Text = "Optimal alpha: " + Math.Round(result.Item1, 3);
            lblBeta.Text = "Optimal beta: " + Math.Round(result.Item2, 3);
            lblStdError.Text = "Standard Error: " + Math.Round(result.Item3, 3);

            Plot(result.Item4, "DES");
        
        }
    }
}
