using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class Login
    {
        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=BDDSistemProc;uid=root;password=abcd1234;";
        public bool IsLoggedIn(string usuario, string contrasena)
        {
            string user = "";
            string password = "";
            try
            {
                string query = "SELECT user_usu, pass_usu FROM Usuario;";

                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = reader.GetString("user_usu");
                            password = reader.GetString("pass_usu");

                            if (user == usuario && password == contrasena)
                            {
                                _connection.Close();
                                return true;
                            }
                        }
                    }
                }

                _connection.Close();
                return false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
                return false;
            }
        }
    }
}
