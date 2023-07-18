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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSistemaProcesos.GUI
{
    public partial class Form_Moldes : Form
    {
        Object[] obj = new Object[6];
        public Form_Moldes()
        {
            InitializeComponent();
            fondo();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_ServContra form_ServContra = new Form_ServContra();
            this.Close();
            form_ServContra.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.png)|*.jpg;*.png";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    pictureBox5.Image = Image.FromFile(rutaImagen);
                }
            }
        }
        private void OpenColorDialog(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog.Color;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalcularMultiplicacion();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalcularMultiplicacion();
        }
        private void CalcularMultiplicacion()
        {
            if (double.TryParse(textBox2.Text, out double valor1) && double.TryParse(textBox3.Text, out double valor2))
            {
                double resultado = valor1 * valor2;
                textBox5.Text = resultado.ToString();
            }
            else
            {
                textBox5.Text = string.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            RegMolde regMolde = new RegMolde();
            obj[0] = comboBox1.SelectedItem.ToString();
            Color selectedColor = colorDialog.Color;
            string codigoColor = selectedColor.Name;
            obj[1] = codigoColor;
            MessageBox.Show(codigoColor);
            obj[2] = comboBox2.SelectedItem.ToString();
            obj[3] = textBox2.Text;
            obj[4] = textBox3.Text;
            obj[5] = textBox5.Text;
            regMolde.registrarMolde(obj);

        }
    }
}
