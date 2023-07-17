using ProyectoSistemaProcesos.CodeBase;
using System.Drawing.Drawing2D;

namespace ProyectoSistemaProcesos
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
            fondo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*Login login = new Login();
            string user = textBox1.Text;
            string password = textBox2.Text;
            bool validar = login.IsLoggedIn(user, password);
            if (validar == true) { */
                Form_Menu form_Menu = new Form_Menu();
                this.Hide();
                form_Menu.Show();
            /*}
            else
            {
                MessageBox.Show("Ingrese las credenciales correctas");
            }*/
        }
    }
}