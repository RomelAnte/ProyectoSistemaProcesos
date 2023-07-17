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
    public partial class Form_Articulo : Form
    {
        public Form_Articulo()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_Menu form_Menu = new Form_Menu();
            this.Close();
            form_Menu.ShowDialog();
        }

        private void Form_Articulo_Load(object sender, EventArgs e)
        {

        }
    }
}
