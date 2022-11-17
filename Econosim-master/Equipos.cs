using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econosim
{
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }

        CL_ConexiónBD conexion = new CL_ConexiónBD();

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu(/*""*/);
            Menu.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Equipos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Equipos_Shown(object sender, EventArgs e)
        {
            conexion.abrir();
            string equipos = InicioSesión.equipo;
            conexion.cargarDatosEquipo(dataGridView1, "usuario", InicioSesión.equipo);
        }
    }
}
