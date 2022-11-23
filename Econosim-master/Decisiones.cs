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
    public partial class Decisiones : Form
    {
        public Decisiones()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPresupuesto_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Decisiones_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(/*""*/);
            menu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void circlebutton3_Click(object sender, EventArgs e)
        {
            /*Decisiones_Almacen_Distribucion_ decisiones_Almacen = new Decisiones_Almacen_Distribucion_();
            decisiones_Almacen.Show();*/
            Decisiones_Distribucion_y_almacenamiento_ decisiones_Distribucion_Y_Almacenamiento_ = new Decisiones_Distribucion_y_almacenamiento_();
            decisiones_Distribucion_Y_Almacenamiento_.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void circlebutton6_Click(object sender, EventArgs e)
        {
            /* Funcion de produccion de marca */
            Decisiones_Produccion_de_Marca_ decisiones_Produccion_De_Marca_ = new Decisiones_Produccion_de_Marca_();
            decisiones_Produccion_De_Marca_.Show();
            this.Hide();
        }

        private void circlebutton5_Click(object sender, EventArgs e)
        {
            /*Decisiones (compensacion) formulario */

            Decisiones_compensacion_ decisiones_compensacion_ = new Decisiones_compensacion_();
            decisiones_compensacion_.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circlebutton4_Click(object sender, EventArgs e)
        {
            Decisiones__Instalaciones_de_produccion_ decisiones__Instalaciones_De_Produccion = new Decisiones__Instalaciones_de_produccion_();
            decisiones__Instalaciones_De_Produccion.Show();
            this.Hide();
        }

        private void circlebutton1_Click(object sender, EventArgs e)
        {
            Decisiones_Finanzas_y_flujo_de_caja_ decisiones_Finanzas_Y_Flujo_de_caja_ = new Decisiones_Finanzas_y_flujo_de_caja_();
            decisiones_Finanzas_Y_Flujo_de_caja_.Show();
            this.Hide();
        }
    }
}


/* C:\Users\Kick\Desktop\Econosim */