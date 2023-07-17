using ProyectoSistemaProcesos.CodeBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaProcesos
{
    public partial class Form_Registro : Form
    {
        object[] obj = new object[9];
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
            textBox6.KeyPress += textBox1_KeyPress;
            textBox8.KeyPress += textBox1_KeyPress;
            textBox1.KeyPress += textBox2_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox7.KeyPress += textBox2_KeyPress;
        }
        public Form_Registro()
        {
            InitializeComponent();
            fondo();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_Menu form_Menu = new Form_Menu();
            this.Hide();
            form_Menu.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegEmpleado regEmpleado = new RegEmpleado();
            obj[0] = textBox2.Text;
            obj[1] = textBox3.Text;
            obj[2] = textBox4.Text;
            obj[3] = dateTimePicker1.Text;
            obj[4] = textBox6.Text;
            obj[5] = textBox7.Text;
            obj[6] = textBox8.Text;
            obj[7] = comboBox1.SelectedItem.ToString();
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                obj[8] = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                obj[8] = false;
            }
            regEmpleado.registrarEmpleado(obj);
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
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RegEmpleado empleado = new RegEmpleado();
            string ci = textBox1.Text;
            empleado.BuscarEmpleado(ci);
            Empleado empleado1 = empleado.BuscarEmpleado(ci);
            if (empleado1 != null)
            {
                textBox2.Text = empleado1.ci;
                textBox3.Text = empleado1.nombre;
                textBox4.Text = empleado1.apellido;
                dateTimePicker1.Text = empleado1.fechaNaci;
                textBox6.Text = empleado1.email;
                textBox7.Text = empleado1.fono;
                textBox8.Text = empleado1.direcc;
                comboBox1.SelectedItem = empleado1.cargo;

                if (empleado1.Estado == true)
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            obj[0] = textBox2.Text;
            obj[1] = textBox3.Text;
            obj[2] = textBox4.Text;
            obj[3] = dateTimePicker1.Text;
            obj[4] = textBox6.Text;
            obj[5] = textBox7.Text;
            obj[6] = textBox8.Text;
            obj[7] = comboBox1.SelectedItem;
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                obj[8] = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                obj[8] = false;
            }
            RegEmpleado regEmpleado = new RegEmpleado();
            regEmpleado.ActualizarEmpleado(obj);
            limpiar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RegEmpleado regEmpleado = new RegEmpleado();
            string ci = textBox1.Text;
            regEmpleado.EliminarEmpleado(obj);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }
    }
}
