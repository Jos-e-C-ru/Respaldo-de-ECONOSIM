using Econosim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Materiasles_1
{
    public partial class Edicion : Form
    {   
        Documentos objDoc = new Documentos();

        public Edicion()
        {
            InitializeComponent();
            LlenarData();
        }

        private void LlenarData()
        {
            dataGridView1.DataSource = objDoc.ListaDocumentos();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();

            Graficos frmr = new Graficos();

            frmr.Show();

        }

        //Documentos objDoc = new Documentos();

        private void button19_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "all files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textruta.Text = openFileDialog1.FileName;
            }
        } 

        private void button9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void circlebutton2_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream MyStrem = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStrem.CopyTo(obj);
            archivo = obj.ToArray();



            objDoc.Nombre = txttitulo.Text;
            objDoc.Documento = archivo;
            objDoc.Extension = openFileDialog1.SafeFileName;
            objDoc.Descripcion = txtdescripcion.Text;
            objDoc.Fecha = txtfecha.Text;


            MessageBox.Show(objDoc.AgregarDocumento());
            LlenarData();

            txtdescripcion.Clear();
            txtfecha.Clear();
            txttitulo.Clear();


        }

        private void circlebutton4_Click(object sender, EventArgs e)
        {
            

            Form frmr = new Form1();
            frmr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frmr = new Form1();

            frmr.Show();
        }

        private void circlebutton5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                objDoc.Id = id;
                var Lista = new List<Documentos>();
                Lista = objDoc.filtroDocumentos();

                foreach(Documentos item in Lista)
                {
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacionCompleta = carpeta + item.Extension;

                    if(!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    if(File.Exists(ubicacionCompleta))
                       File.Delete(ubicacionCompleta);

                    File.WriteAllBytes(ubicacionCompleta, item.Documento);
                    Process.Start(ubicacionCompleta);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void circlebutton6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server= DAVID-PC;integrated security=True; database = proyecto_grupo_#3");
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                conexion.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM DOC WHERE id =@id", conexion);

                    cmd.Parameters.AddWithValue("@id", item.Cells["id"].Value);
                    int i = cmd.ExecuteNonQuery();
                    conexion.Close();

                    if (i != 0)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                        MessageBox.Show("Deleted Succefull!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Deleted Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sql not execute", "Error Sql" + ex.Message);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form resultados = new Resultados();
            resultados.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form equipos = new Equipos();
            equipos.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

    }


    /*private void Refresh()
{
using (Model.Save_fileEntities2 = new Model.Save_fileEntities2())
{
var lst = from d in db.document
select new { d.name };
dgvLista.DataSource = lst.ToList();
}
}*/

    //code for save
    /*if(txttitulo.Text.Trim().Equals("")|| textruta.Text.Trim().Equals(""))
            {
                MessageBox.Show("Parametros no validos");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            } 
            using (Model.Save_fileEntities3 db= new Model.Save_fileEntities3())
            {
                Model.document oDocument = new Model.document();
                oDocument.titulo = txttitulo.Text.Trim();
                oDocument.realname = openFileDialog1.SafeFileName;
                oDocument.doc = file;
               

                db.documents.Add(oDocument);
                db.SaveChanges();
            }   */
}

