using ProyectoSistemaProcesos.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaProcesos
{
    public partial class Form_ServContra : Form
    {
        public Form_ServContra()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Moldes form_Moldes = new Form_Moldes();
            this.Close();
            form_Moldes.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form_Empleado form_Empleado = new Form_Empleado();
            this.Close();
            form_Empleado.Show();
        }
    }
}
