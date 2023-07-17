using ProyectoSistemaProcesos.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaProcesos
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form_Menu2 menu2 = new Form_Menu2();
            this.Close();
            menu2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form_Reportes form_Reportes = new Form_Reportes();
            this.Close();
            form_Reportes.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form_Registro form_Registro = new Form_Registro();
            this.Hide();
            form_Registro.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_Articulo form_Articulo = new Form_Articulo();
            this.Close();
            form_Articulo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Inventario form_Inventario = new Form_Inventario();
            this.Close();
            form_Inventario.Show();
        }
    }
}
