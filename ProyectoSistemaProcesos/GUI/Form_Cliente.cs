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

namespace ProyectoSistemaProcesos
{
    public partial class Form_Cliente : Form
    {
        object[] obj = new object[7];
        Usuario usuario = new Usuario();
        public void limpiar()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
            checkBox1.Checked = false;
            textBox2.Focus();
        }
        public void validar()
        {
            textBox3.KeyPress += textBox1_KeyPress;
            textBox4.KeyPress += textBox1_KeyPress;
            textBox8.KeyPress += textBox1_KeyPress;
            textBox1.KeyPress += textBox2_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox7.KeyPress += textBox2_KeyPress;
        }
        public Form_Cliente()
        {
            InitializeComponent();
            fondo();
            validar();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_Menu2 form_Menu2 = new Form_Menu2();
            this.Close();
            form_Menu2.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            usuario.CI = textBox2.Text;
            usuario.Nombre = textBox3.Text;
            usuario.Apellido = textBox4.Text;
            usuario.Telefono = textBox7.Text;
            usuario.Direccion = textBox8.Text;
            usuario.Estado = checkBox1.Checked;
            usuario.registrar(1);
            limpiar();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                usuario.Estado = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                usuario.Estado = false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            usuario.CI = textBox2.Text;
            usuario.Nombre = textBox3.Text;
            usuario.Apellido = textBox4.Text;
            usuario.Telefono = textBox7.Text;
            usuario.Direccion = textBox8.Text;
            usuario.Estado = checkBox1.Checked;
            usuario.Actualizar(1);
            limpiar();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string ci = textBox1.Text;
            bool cliente = usuario.Buscar(1, ci);
            if (cliente != false)
            {
                textBox2.Text = usuario.CI;
                textBox3.Text = usuario.Nombre;
                textBox4.Text = usuario.Apellido;
                textBox7.Text = usuario.Telefono;
                textBox8.Text = usuario.Direccion;

                if (usuario.Estado == true)
                {
                    checkBox1.Text = "Activo";
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Text = "Pasivo";
                    checkBox1.Checked = false;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string ci = textBox1.Text;
            usuario.Eliminar(1,ci);
        }
    }
}