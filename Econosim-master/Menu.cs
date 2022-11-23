using Materiasles_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econosim
{
    public partial class Menu : Form
    {
        Inicio inicio = new Inicio();
        InicioSesión inicioSesión = new InicioSesión();
        private string v;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string v)
        {
            this.v = v;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            InicioSesión.idusuario = "";
            InicioSesión.nombre = "";
            InicioSesión.apellido = "";
            InicioSesión.correo = "";
            InicioSesión.equipo = "";
            InicioSesión.tipo = "";
            this.Close();
            inicio.Show();

        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            lblBienvenida.Text = ("Bienvenido, " + InicioSesión.nombre + " " + InicioSesión.apellido);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            Form materiales = new Materiasles_1.Form1();
            materiales.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form frm = new Materiasles_1.Form1();
            frm.Show();
            this.Hide();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form equipos = new Equipos();
            equipos.Show();
            this.Hide();
        }

        private void btnCalendarios_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form resultados = new Resultados();
            resultados.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form Decisiones = new Decisiones();
            Decisiones.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form perfil = new Perfil();
            perfil.Show();
            this.Hide();
        }


        private void circlebutton5_Click(object sender, EventArgs e)
        {

            if (InicioSesión.tipo == "Administrador")
            {
                Form participantes = new AdmParticipantes();
                participantes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USTED NO CUENTA CON LOS PERSMISOS DE ADMINISTRADOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form calendario = new Calendario();
            calendario.Show();
            this.Hide();
        }
    }
}
