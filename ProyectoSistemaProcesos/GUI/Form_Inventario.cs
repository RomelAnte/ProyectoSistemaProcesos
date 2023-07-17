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
    public partial class Form_Inventario : Form
    {
        public Form_Inventario()
        {
            InitializeComponent();
            fondo();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Menu form_Menu = new Form_Menu();
            this.Close();
            form_Menu.ShowDialog();
        }
    }
}
