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
    public partial class Form_Menu2 : Form
    {
        public Form_Menu2()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Cliente form_Cliente = new Form_Cliente();
            this.Close();
            form_Cliente.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form_Menu form_Menu = new Form_Menu();
            form_Menu.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_Empleado form_Empleado = new Form_Empleado();
            this.Close();
            form_Empleado.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form_Ventas_Pagos form_Ventas_Pagos = new Form_Ventas_Pagos();
            this.Close();
            form_Ventas_Pagos.Show();
        }
    }
}
