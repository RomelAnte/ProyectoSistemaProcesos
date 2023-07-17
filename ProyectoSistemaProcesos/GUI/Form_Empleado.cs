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
    public partial class Form_Empleado : Form
    {
        public Form_Empleado()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_Menu2 form_Menu2 = new Form_Menu2();
            this.Close();
            form_Menu2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Maquilador form_Maquilador = new Form_Maquilador();
            this.Close();
            form_Maquilador.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_ServContra form_ServContra = new Form_ServContra();
            this.Close();
            form_ServContra.Show();
        }
    }
}
