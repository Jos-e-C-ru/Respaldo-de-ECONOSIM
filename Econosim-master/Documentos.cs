using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Materiasles_1
{
    public class Documentos
    {
        private int id;
        private string nombre;
        private byte[] documento;
        private string extension;

        private string descripcion;
        private string fecha;

        SqlConnection conexion = new SqlConnection("server=DAVID-PC;integrated security=True; database = proyecto_grupo_#3");

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }


        public string AgregarDocumento()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into DOC values (@nombre, @documento, @extension, @descripcion, @fecha)", conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@extension", extension);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "Agregado con exito";

        }
        //cargar
        //eliminar
        public DataTable ListaDocumentos()
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand("select ID, NOMBRE, DESCRIPCION, FECHA from DOC", conexion);
            SqlDataReader resultado = comando.ExecuteReader();

           if (resultado.HasRows) tabla.Load(resultado);

            resultado.Close();
            conexion.Close();
            return tabla;
        }
        public DataTable ArchivoPorId()
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from DOC where ID = @ID", conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@ID", id);
            SqlDataReader lector = comando.ExecuteReader();
            tabla.Load(lector);
            lector.Close();
            conexion.Close();
            return tabla;
        }
        public List<Documentos> filtroDocumentos()
        {
            var tabla = ArchivoPorId();
            var infoDocumento = new List<Documentos>();
            foreach(DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new Documentos
                {
                    Id = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Documento = (byte[])item[2],
                    Extension = item[3].ToString(),
                    Descripcion = item[4].ToString(),
                    Fecha = item[5].ToString()

                });
            }
            return infoDocumento;
        }
        public DataTable EliminaroPorId()
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete DOC where ID = @ID", conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@ID", id);
            SqlDataReader lector = comando.ExecuteReader();
            tabla.Load(lector);
            lector.Close();
            return tabla;
        }
    }
}
