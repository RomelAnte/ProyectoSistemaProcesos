using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class RegCliente
    {
        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=BDDSistemProc;uid=root;password=abcd1234;";
        public void registrarCliente(object[] obj)
        {
            try
            {
                string ci = "";
                string query1 = "select CI_Cli from Clientes where CI_Cli=@CI_Cli;";
                string query = "INSERT INTO Clientes (nom_Cli, apell_Cli, CI_Cli, fono_Cli, direc_Cli, E_Cli) VALUES (@nom_Cli, @apell_Cli, @CI_Cli, @fono_Cli, @direc_Cli, @E_Cli);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Cli", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ci = reader.GetString("CI_Cli");
                        }
                    }
                }
                if (ci != obj[0].ToString())
                {
                    using (MySqlCommand command = new MySqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@nom_Cli", obj[1]);
                        command.Parameters.AddWithValue("@apell_Cli", obj[2]);
                        command.Parameters.AddWithValue("@CI_Cli", obj[0]);
                        command.Parameters.AddWithValue("@fono_Cli", obj[3]);
                        command.Parameters.AddWithValue("@direc_Cli", obj[4]);
                        command.Parameters.AddWithValue("@E_Cli", obj[5]);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inserción exitosa");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar");
                        }
                    }
                    _connection.Close();
                }
                else
                {
                    MessageBox.Show("El cliente ya existe en la base de datos");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
        public Cliente BuscarCliente(string ci)
        {
            Cliente cliente = null;
            try
            {
                string query1 = "select nom_Cli,apell_Cli,CI_Cli,fono_Cli,direc_Cli,E_Cli from Clientes where CI_Cli=@ci;";
                using (MySqlConnection _connection = new MySqlConnection(connectionString))
                {
                    _connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, _connection))
                    {
                        command.Parameters.AddWithValue("@ci", ci);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = new Cliente();
                                cliente.Nombre = reader.GetString("nom_Cli");
                                cliente.Apellido = reader.GetString("apell_Cli");
                                cliente.CI = reader.GetString("CI_Cli");
                                cliente.Telefono = reader.GetString("fono_Cli");
                                cliente.Direccion = reader.GetString("direc_Cli");
                                cliente.Estado = reader.GetBoolean("E_Cli");
                            }
                        }
                    }
                    _connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
            return cliente;
        }
        public void ActualizarCliente(object[] obj)
        {
            int idCliente = -1;
            try
            {
                string query1 = "SELECT id_Cli FROM Clientes WHERE CI_Cli = @CI_Cli;";
                string query = "UPDATE Clientes SET nom_Cli = @nom_Cli, apell_Cli = @apell_Cli, " +
                    "CI_Cli = @CI_Cli, fono_Cli = @fono_Cli, direc_Cli = @direc_Cli, E_Cli = @E_Cli WHERE id_Cli = @id_Cli;";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Cli", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idCliente = reader.GetInt32("id_Cli");
                        }
                    }
                }

                if (idCliente != -1)
                {
                    using (MySqlCommand command = new MySqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@nom_Cli", obj[1]);
                        command.Parameters.AddWithValue("@apell_Cli", obj[2]);
                        command.Parameters.AddWithValue("@CI_Cli", obj[0]);
                        command.Parameters.AddWithValue("@fono_Cli", obj[3]);
                        command.Parameters.AddWithValue("@direc_Cli", obj[4]);
                        command.Parameters.AddWithValue("@E_Cli", obj[5]);
                        command.Parameters.AddWithValue("@id_Cli", idCliente);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Actualización exitosa");
                            Console.WriteLine();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente");
                    Console.WriteLine();
                }
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
                private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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
        public void EliminarCliente(object[] obj)
        {
            int idCliente = -1;
            try
            {
                string query1 = "SELECT id_Cli FROM Clientes WHERE CI_Cli = @CI_Cli;";
                string query = "DELETE FROM Clientes WHERE id_Cli = @id_Cli";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Cli", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idCliente = reader.GetInt32("id_Cli");
                        }
                    }
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_Cli", idCliente);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Eliminación exitosa");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el registro");
                        }
                    }

                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
    }
}
