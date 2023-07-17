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
            obj[0] = textBox2.Text;
            obj[1] = textBox3.Text;
            obj[2] = textBox4.Text;
            obj[3] = textBox7.Text;
            obj[4] = textBox8.Text;
            RegCliente regCliente = new RegCliente();
            regCliente.registrarCliente(obj);
            limpiar();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                obj[5] = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                obj[5] = false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            obj[0] = textBox2.Text;
            obj[1] = textBox3.Text;
            obj[2] = textBox4.Text;
            obj[3] = textBox7.Text;
            obj[4] = textBox8.Text;
            RegCliente regCliente = new RegCliente();
            regCliente.ActualizarCliente(obj);
            limpiar();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RegCliente regCliente = new RegCliente();
            string ci = textBox1.Text;
            regCliente.BuscarCliente(ci);
            Cliente cliente = regCliente.BuscarCliente(ci);
            if (cliente != null)
            {
                textBox2.Text = cliente.CI;
                textBox3.Text = cliente.Nombre;
                textBox4.Text = cliente.Apellido;
                textBox7.Text = cliente.Telefono;
                textBox8.Text = cliente.Direccion;

                if (cliente.Estado == true)
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
            // Verifica si el carácter ingresado no es una letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RegCliente regCliente = new RegCliente();
            regCliente.EliminarCliente(obj);
        }
    }
}