using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ColeccMP3
{
    public partial class FormGrafico : Form
    {
        public FormGrafico()
        {
            InitializeComponent();
        }

        public void SetDatos(SortedList<string, int> datos)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Por categoría");
            chart1.Series["Por categoría"].ChartType =
                    SeriesChartType.Bar;
            foreach (var dato in datos)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueXY(
                    dato.Key,
                    dato.Value);
                chart1.Series["Por categoría"].Points.Add(dp);
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
