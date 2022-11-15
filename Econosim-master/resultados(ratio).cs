using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Econosim
{
    public partial class resultados_ratio_ : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-LPK0UAA; Initial Catalog = proyecto_grupo_#3; Integrated security = true ");
        SqlCommand cmd;
        SqlDataReader dr;
        public resultados_ratio_()
        {
            InitializeComponent();
        }

        private void resultados_ratio__Load(object sender, EventArgs e)
        {
            grafico_prduccion();

        }

        ArrayList Marca = new ArrayList();
        ArrayList TOTAL = new ArrayList();

        private void grafico_prduccion()
        {
            cmd = new SqlCommand("Ratio_decisiones", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Marca.Add(dr.GetString(0));
                TOTAL.Add(dr.GetInt32(1));
            }
            chart_produccion_total.Series[0].Points.DataBindXY(Marca, TOTAL);
            dr.Close();
            conexion.Close();
        }

        private void chart_produccion_total_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.Show();
            this.Hide();
        }
    }
}
