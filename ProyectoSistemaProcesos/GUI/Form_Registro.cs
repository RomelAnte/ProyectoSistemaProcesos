using ProyectoSistemaProcesos.CodeBase;

namespace ProyectoSistemaProcesos
{
    public partial class Form_Registro
        : Form
    {
        Usuario regUsuario = new Usuario();
        object[] obj = new object[9];
        public void limpiar()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            checkBox1.Checked = false;
            textBox2.Focus();
            comboBox1.Text = string.Empty;
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
            regUsuario.CI = textBox2.Text;
            regUsuario.Nombre = textBox3.Text;
            regUsuario.Apellido = textBox4.Text;
            regUsuario.fechaNaci = dateTimePicker1.Text;
            regUsuario.email = textBox6.Text;
            regUsuario.Telefono = textBox7.Text;
            regUsuario.Direccion = textBox8.Text;
            regUsuario.cargo = comboBox1.SelectedItem.ToString();
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                regUsuario.Estado = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                regUsuario.Estado = false;
            }
            regUsuario.registrar(2);
            limpiar();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                regUsuario.Estado = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                regUsuario.Estado = false;
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            regUsuario.CI = textBox1.Text;
            bool empleado = regUsuario.Buscar(2);
            if (empleado != false)
            {
                textBox2.Text = regUsuario.CI;
                textBox3.Text = regUsuario.Nombre;
                textBox4.Text = regUsuario.Apellido;
                dateTimePicker1.Text = regUsuario.fechaNaci;
                textBox6.Text = regUsuario.email;
                textBox7.Text = regUsuario.Telefono;
                textBox8.Text = regUsuario.Direccion;
                comboBox1.SelectedItem = regUsuario.cargo;

                if (regUsuario.Estado == true)
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
            regUsuario.CI = textBox2.Text;
            regUsuario.Nombre = textBox3.Text;
            regUsuario.Apellido = textBox4.Text;
            regUsuario.fechaNaci = dateTimePicker1.Text;
            regUsuario.email = textBox6.Text;
            regUsuario.Telefono = textBox7.Text;
            regUsuario.Direccion = textBox8.Text;
            regUsuario.cargo = Convert.ToString(comboBox1.SelectedItem);
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Activo";
                regUsuario.Estado = true;
            }
            else
            {
                checkBox1.Text = "Pasivo";
                regUsuario.Estado = false;
            }
            regUsuario.Actualizar(2);
            limpiar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            regUsuario.CI = textBox1.Text;
            regUsuario.Eliminar(2);
            limpiar();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
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
