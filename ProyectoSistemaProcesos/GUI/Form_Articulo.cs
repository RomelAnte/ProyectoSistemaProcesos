using ProyectoSistemaProcesos.CodeBase;
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
        Articulos articulos = new Articulos();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            articulos.Nombre = textBox2.Text;
            articulos.Cantidad = int.Parse(textBox4.Text);
            articulos.Material = comboBox1.SelectedItem.ToString();
            articulos.categoria = textBox4.Text;
            articulos.FechAdquisicion = dateTimePicker1.Text;
            articulos.Costo = Convert.ToDouble(textBox7.Text);
            articulos.Descripcion = textBox8.Text;
            articulos.registrar();
        }
    }
}
