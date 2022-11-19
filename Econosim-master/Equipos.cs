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


        private void label2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void Equipos_Shown(object sender, EventArgs e)
        {
            conexion.abrir();
            string equipos = InicioSesión.equipo;
            conexion.cargarDatosEquipo(dataGridView1, "usuario", InicioSesión.equipo);
        }
    }
}
