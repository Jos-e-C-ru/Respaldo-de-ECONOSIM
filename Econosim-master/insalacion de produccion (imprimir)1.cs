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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Econosim
{
    public partial class insalacion_de_produccion__imprimir_1 : Form
    {
        public insalacion_de_produccion__imprimir_1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = proyecto_grupo_#3; Integrated security = true ");

        private void insalacion_de_produccion__imprimir_1_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM instalacion_de_produccion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_espere.Visible = true;
            lbl_espere.Text = "Exportando datos";
            exportaraexcel(dataGridView1);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Decisiones__Instalaciones_de_produccion_ decisiones__Instalaciones_De_Produccion = new Decisiones__Instalaciones_de_produccion_();
            decisiones__Instalaciones_De_Produccion.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 10, 10);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = proyecto_grupo_#3; Integrated security = true ");
                SqlCommand cmd = new SqlCommand("delete from instalacion_de_produccion where ID_instalacion=" + dataGridView1.SelectedRows[0].Cells[0].Value, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MessageBox.Show("Registro Eliminado");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
