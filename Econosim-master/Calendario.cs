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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = dateTimePicker1.Value.ToString();
            txt_rango.Text = monthCalendar1.SelectionRange.ToString();
            txt_inicio.Text = monthCalendar1.SelectionStart.Date.ToString();
            txt_final.Text = monthCalendar1.SelectionRange.End.ToString();
                
        }
    }
}
