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

namespace Materiasles_1
{
    public partial class Graficos : Form
    {   
        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            string[] titles = { "Equipo #1", "Equipo #2", "Equipo #3" };
            int[] vector = { 9, 6, 10 };
            chart1.Palette = ChartColorPalette.Fire;

            chart1.Titles.Add("Avance por Mes");
            for (int i = 0; i < titles.Length; i++)
            {
                Series ti = chart1.Series.Add(titles[i]);
                ti.Label = vector[i].ToString();
                ti.Points.Add(vector[i]);

            }

            string[] x = { "Equipo #1", "Equipo #2", "Equipo #3" };
            double[] y = { 2.1, 3.4, 1.7 };
            chart2.Palette = ChartColorPalette.SeaGreen;

            chart2.Titles.Add("Ganancias");
            for (int i = 0; i < x.Length; i++)
            {
                Series ti2 = chart2.Series.Add(x[i]);
                ti2.Label = y[i].ToString();
                ti2.Points.Add(y[i]);

            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frmr = new Form1();

            frmr.Show();
        }
    }
}
