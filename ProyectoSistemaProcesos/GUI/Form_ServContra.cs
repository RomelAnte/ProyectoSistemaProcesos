using ProyectoSistemaProcesos.CodeBase;
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
        Reg_ServContra reg_ServContra = new Reg_ServContra();
        Object[] obj = new Object[6];
        public Form_ServContra()
        {
            InitializeComponent();
            fondo();
            LlenarComboBox();
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
        private void LlenarComboBox()
        {
            Reg_ServContra reg_ServContra = new Reg_ServContra();

            List<string> nombres = reg_ServContra.ObtenerNombresDesdeBD();

            comboBox1.DataSource = nombres;
        }

        private void Form_ServContra_Load(object sender, EventArgs e)
        {
            Reg_ServContra servicioContra = new Reg_ServContra();
            List<string> datos = servicioContra.ObtenerNombresDesdeBD();
            comboBox1.DataSource = datos;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            obj[0] = comboBox1.SelectedItem.ToString();
            obj[1] = dateTimePicker1.Text;
            obj[2] = dateTimePicker2.Text;
            reg_ServContra.registrar(obj);
        }
    }
}
