using Econosim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materiasles_1
{   
    public partial class Form1 : Form
    {
        Documentos objDoc = new Documentos();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = objDoc.ListaDocumentos();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();

            Graficos frmr = new Graficos();

            frmr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form resultados = new Resultados();
            resultados.Show();
            this.Hide();
        }



        private void circlebutton9_Click(object sender, EventArgs e)
        {
            

            Form frm = new Edicion();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void circlebutton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                objDoc.Id = id;
                var Lista = new List<Documentos>();
                Lista = objDoc.filtroDocumentos();

                foreach (Documentos item in Lista)
                {
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacionCompleta = carpeta + item.Extension;

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    if (File.Exists(ubicacionCompleta))
                        File.Delete(ubicacionCompleta);

                    File.WriteAllBytes(ubicacionCompleta, item.Documento);
                    Process.Start(ubicacionCompleta);
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form perfil = new Perfil();
            perfil.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form Decisiones = new Decisiones();
            Decisiones.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form equipos = new Equipos();
            equipos.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form menu = new Econosim.Menu();
            menu.Show();
            this.Hide();

        }
    }
}
