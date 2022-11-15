using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Econosim
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }
        SqlCommand command;
        CL_ConexiónBD conexiónBD = new CL_ConexiónBD();

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            conexiónBD.abrir();
        }

     

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT nombre_de_usuario, emali from usuario WHERE nombre_de_usuario= '" + txtNuevoUser.Text + "' OR emali= '" + txtNuevoCorreo.Text + "'", conexiónBD.sc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("NOMBRE DE USUARIO O CORREO YA EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (this.txtNuevoNombre.Text == String.Empty || txtNuevoApellido.Text == String.Empty || txtNuevoCorreo.Text == String.Empty || txtNuevoUser.Text == String.Empty || txtNuevaContra.Text == String.Empty || txtConfirmacion.Text == String.Empty || txtNumEquipo.Text == String.Empty ||cmbTipoUsuario.Text==String.Empty)
                    {
                        MessageBox.Show("LLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtNuevaContra.Text.Trim() == txtConfirmacion.Text.Trim())
                        {
                            command = new SqlCommand("INSERT INTO usuario (nombre, apellido, nombre_de_usuario, contrasena, emali, numero_de_grupo, tipo_de_Usuario)" + "VALUES('" + txtNuevoNombre.Text + "','" + txtNuevoApellido.Text + "','" + txtNuevoUser.Text + "','" + txtNuevaContra.Text + "','" + txtNuevoCorreo.Text + "','" + txtNumEquipo.Text + "','"+cmbTipoUsuario.Text+"')", conexiónBD.sc);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro Insertado");

                            txtNuevoNombre.Clear();
                            txtNuevoApellido.Clear();
                            txtNuevoCorreo.Clear();
                            txtNuevoUser.Clear();
                            txtNuevaContra.Clear();
                            txtConfirmacion.Clear();
                            txtNumEquipo.Clear();
                            txtNuevoNombre.Focus();
                        }
                        else
                        {
                            MessageBox.Show("LLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNuevaContra.Clear();
                            txtConfirmacion.Clear();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNuevoNombre.Clear();
            txtNuevoApellido.Clear();
            txtNuevoCorreo.Clear();
            txtNuevoUser.Clear();
            txtNuevaContra.Clear();
            txtNumEquipo.Clear();
            txtNuevoNombre.Focus();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
