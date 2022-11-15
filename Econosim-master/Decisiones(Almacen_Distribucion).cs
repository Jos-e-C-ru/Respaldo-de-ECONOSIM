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
    public partial class Decisiones_Almacen_Distribucion_ : Form
    {
        public Decisiones_Almacen_Distribucion_()
        {
            InitializeComponent();
        }

        private void porciento_infraestruct_TextChanged(object sender, EventArgs e)
        {
            string valor_presupuesto = txtPresup_Almacenes.Text;
            string porcent_Infraestructura = porciento_infraestruct.Text.Trim().ToString();
           // string valor_infraestrucura = lblAsign_Infraestructura.Text;

            if (!string.IsNullOrEmpty(porcent_Infraestructura) && !string.IsNullOrEmpty(valor_presupuesto))
            {
                int porcentajeInf = 0;
                Double valor_inf = 0.0;

                if(int.TryParse(porcent_Infraestructura,out porcentajeInf) && Double.TryParse(valor_presupuesto, out valor_inf))
                {
                    Double asign_infraestruc = (porcentajeInf * valor_inf) / 100;
                    lblAsign_Infraestructura.Text = ("L. " + asign_infraestruc.ToString());

                }
                else
                {
                    MessageBox.Show("No es posible realizar la operacion");
                }

            }
        }

        private void txtPresup_Almacenes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void porciento_instalacion_TextChanged(object sender, EventArgs e)
        {
            string valor_presupuesto = txtPresup_Almacenes.Text;
            string porcent_instalacion = porciento_instalacion.Text.Trim().ToString();


            if (!string.IsNullOrEmpty(porcent_instalacion) && !string.IsNullOrEmpty(valor_presupuesto))
            {
                int porcentajeInst = 0;
                Double valor_inst = 0.0;

                if (int.TryParse(porcent_instalacion, out porcentajeInst) && Double.TryParse(valor_presupuesto, out valor_inst))
                {
                    Double asign_instalacion = (porcentajeInst * valor_inst) / 100;
                    lblAsign_Instalacion.Text = ("L. " + asign_instalacion.ToString());

                }
                else
                {
                    MessageBox.Show("No es posible realizar la operacion");
                }

            }
        }

        private void porciento_gestión_TextChanged(object sender, EventArgs e)
        {

            string valor_presupuesto = txtPresup_Almacenes.Text;
            string porcent_gestión = porciento_gestión.Text.Trim().ToString();
          

            if (!string.IsNullOrEmpty(porcent_gestión) && !string.IsNullOrEmpty(valor_presupuesto))
            {
                int porcentajeGest = 0;
                Double valor_gest = 0.0;

                if (int.TryParse(porcent_gestión, out porcentajeGest) && Double.TryParse(valor_presupuesto, out valor_gest))
                {
                    Double asign_gestion = (porcentajeGest * valor_gest) / 100;
                    lblAsign_Gestion.Text = ("L. " + asign_gestion.ToString());

                }
                else
                {
                    MessageBox.Show("No es posible realizar la operacion");
                }

            }

        }

        private void porciento_op_TextChanged(object sender, EventArgs e)
        {


            string valor_presupuesto = txtPresup_Almacenes.Text;
            string porcent_operacion = porciento_op.Text.Trim().ToString();


            if (!string.IsNullOrEmpty(porcent_operacion) && !string.IsNullOrEmpty(valor_presupuesto))
            {
                int porcentajeOp = 0;
                Double valor_op = 0.0;

                if (int.TryParse(porcent_operacion, out porcentajeOp) && Double.TryParse(valor_presupuesto, out valor_op))
                {
                    Double asign_operacion = (porcentajeOp * valor_op) / 100;
                    lblAsign_Operación.Text = ("L. " + asign_operacion.ToString());

                }
                else
                {
                    MessageBox.Show("No es posible realizar la operacion");
                }

            }

        }

        private void lblAsign_Infraestructura_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form decisiones = new Decisiones();
            decisiones.Show();
            this.Hide();
        }
    }
}
