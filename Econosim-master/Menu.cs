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
        //String nombre_usuario;

        Inicio inicio = new Inicio();
        private string v;

        public Menu(/*String usuario*/)
        {
            InitializeComponent();
            //nombre_usuario = usuario;
        }

        public Menu(string v)
        {
            this.v = v;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = ("Bienvenido, " + InicioSesión.nombre + " " + InicioSesión.apellido);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            inicio.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDecisiones_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            
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

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

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
