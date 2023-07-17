using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaProcesos.GUI
{
    public partial class Form_Ventas_Pagos : Form
    {
        public Form_Ventas_Pagos()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Menu2 menu = new Form_Menu2();
            this.Close();
            menu.Show();
        }
    }
}
