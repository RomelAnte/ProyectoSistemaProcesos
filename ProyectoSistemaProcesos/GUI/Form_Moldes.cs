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
    public partial class Form_Moldes : Form
    {
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
    }
}
