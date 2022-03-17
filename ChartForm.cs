using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MatrixSample
{
    public partial class ChartForm : Form
    {
        int[,] matrix1;
        int[,] matrix2;

        public ChartForm(int[,] matrix1, int[,] matrix2)
        {
            this.matrix1 = matrix1;
            this.matrix2 = matrix2;
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            AddSeries(matrix1, "Matrix 1");
            AddSeries(matrix2, "Matrix 2");
            chart1.Titles.Add("Number of unique elements by rows");
            chart1.ChartAreas[0].AxisX.Title = "Row index";
        }

        void AddSeries(int[,] matrix, string name)
        {
            var series = new Series { ChartType = SeriesChartType.Column, Name = name };
            var set = new HashSet<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                set.Clear();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    set.Add(matrix[i, j]);
                }
                series.Points.Add(set.Count);
            }
            chart1.Series.Add(series);
        }
    }
}
