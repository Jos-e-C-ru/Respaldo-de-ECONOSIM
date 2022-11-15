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

namespace Econosim
{
    public partial class resultado_informe_de_mercado_ : Form
    {
        string SSCadenaConexion = "Data Source = DESKTOP-LPK0UAA; Initial Catalog = proyecto_grupo_#3; Integrated security = true ";
        public resultado_informe_de_mercado_()
        {
            InitializeComponent();
        }

        private void resultado_informe_de_mercado__Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenargrid(SSCadenaConexion);
        }

        private DataTable llenargrid(string CadenaConexion)
        {
            DataTable tlb = new DataTable();
            SqlConnection sqlcon1 = new SqlConnection(CadenaConexion);
            SqlCommand sqlcom1;
            SqlDataAdapter sqlData1;


            sqlcon1.Open();
            sqlcom1 = new SqlCommand("mercado", sqlcon1);
            sqlData1 = new SqlDataAdapter(sqlcom1);
            sqlcom1.CommandType = CommandType.StoredProcedure;
            sqlData1.Fill(tlb);
            sqlcon1.Close();
            return tlb;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            label7.Text = dataGridView1.SelectedCells[1].Value.ToString();
            label8.Text = dataGridView1.SelectedCells[2].Value.ToString();
            label9.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
    }
}
