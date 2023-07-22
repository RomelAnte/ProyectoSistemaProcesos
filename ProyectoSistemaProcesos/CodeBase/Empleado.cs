using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class Empleado:Usuario
    {
        public string fechaNaci { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }

        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=BDDSistemProc;uid=root;password=abcd1234;";
        public void registrar()
        {
            try
            {
                string ci = "";
                string query1 = "select CI_Maqui from Maquiladores where CI_Maqui=@CI_Maqui;";
                string query = "INSERT INTO Maquiladores (CI_Maqui, nom_Maqui, apell_Maqui, fechaNaci, mail_Maqui,fono_Maqui,direc_Maqui,cargo_Maqui,E_Maqui) " +
                    "VALUES (@CI_Maqui, @nom_Maqui, @apell_Maqui, @fechaNaci, @mail_Maqui, @fono_Maqui,@direc_Maqui,@cargo_Maqui,@E_Maqui);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Maqui", this.CI);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ci = reader.GetString("CI_Maqui");
                        }
                    }
                }
                if (ci != this.CI)
                {
                    using (MySqlCommand command = new MySqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@CI_Maqui", this.CI);
                        command.Parameters.AddWithValue("@nom_Maqui", this.Nombre);
                        command.Parameters.AddWithValue("@apell_Maqui", this.Apellido);
                        command.Parameters.AddWithValue("@fechaNaci", this.fechaNaci);
                        command.Parameters.AddWithValue("@mail_Maqui", this.email);
                        command.Parameters.AddWithValue("@fono_Maqui", this.Telefono);
                        command.Parameters.AddWithValue("@direc_Maqui", this.Direccion);
                        command.Parameters.AddWithValue("@cargo_Maqui", this.cargo);
                        command.Parameters.AddWithValue("@E_Maqui", this.Estado);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inserción exitosa");
                            Console.WriteLine();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar");
                            Console.WriteLine();
                        }
                    }
                    _connection.Close();
                }
                else
                {
                    MessageBox.Show("El empleado ya existe en la base de datos");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
        public Empleado Buscar(string ci)
        {
            Empleado empleado = null;
            try
            {
                string query1 = "select CI_Maqui, nom_Maqui, apell_Maqui, fechaNaci, mail_Maqui,fono_Maqui,direc_Maqui,cargo_Maqui,E_Maqui from Maquiladores where CI_Maqui=@CI_Maqui;";
                using (MySqlConnection _connection = new MySqlConnection(connectionString))
                {
                    _connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, _connection))
                    {
                        command.Parameters.AddWithValue("@CI_Maqui", ci);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.CI = reader.GetString("CI_Maqui");
                                this.Nombre = reader.GetString("nom_Maqui");
                                this.Apellido = reader.GetString("apell_Maqui");
                                this.fechaNaci = reader.GetString("fechaNaci");
                                this.email = reader.GetString("mail_Maqui");
                                this.Telefono = reader.GetString("fono_Maqui");
                                this.Direccion = reader.GetString("direc_Maqui");
                                this.cargo = reader.GetString("cargo_Maqui");
                                this.Estado = reader.GetBoolean("E_Maqui");

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
            return empleado;
        }
        public void ActualizarEmpleado(object[] obj)
        {
            int idEmp = -1;
            try
            {
                string query1 = "SELECT id_Maqui FROM Maquiladores WHERE CI_Maqui = @CI_Maqui;";
                string query = "UPDATE Maquiladores SET CI_Maqui = @CI_Maqui, nom_Maqui = @nom_Maqui, " +
                    "apell_Maqui = @apell_Maqui, fechaNaci = @fechaNaci, mail_Maqui = @mail_Maqui," +
                    "fono_Maqui = @fono_Maqui, direc_Maqui = @direc_Maqui, cargo_Maqui = @cargo_Maqui," +
                    "E_Maqui = @E_Maqui WHERE id_Maqui = @id_Maqui;";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Maqui", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idEmp = reader.GetInt32("id_Maqui");
                        }
                    }
                }

                if (idEmp != -1)
                {
                    using (MySqlCommand command = new MySqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@CI_Maqui", obj[0]);
                        command.Parameters.AddWithValue("@nom_Maqui", obj[1]);
                        command.Parameters.AddWithValue("@apell_Maqui", obj[2]);
                        command.Parameters.AddWithValue("@fechaNaci", obj[3]);
                        command.Parameters.AddWithValue("@mail_Maqui", obj[4]);
                        command.Parameters.AddWithValue("@fono_Maqui", obj[5]);
                        command.Parameters.AddWithValue("@direc_Maqui", obj[6]);
                        command.Parameters.AddWithValue("@cargo_Maqui", obj[7]);
                        command.Parameters.AddWithValue("@E_Maqui", obj[8]);
                        command.Parameters.AddWithValue("@id_Maqui", idEmp);
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
                    MessageBox.Show("No se encontró el empleado");
                    Console.WriteLine();
                }
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
        public void EliminarEmpleado(object[] obj)
        {
            int idCliente = -1;
            try
            {
                string query1 = "SELECT id_Maqui FROM Maquiladores WHERE CI_Maqui = @CI_Maqui;";
                string query = "DELETE FROM Maquiladores WHERE id_Maqui = @id_Maqui";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Maqui", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idCliente = reader.GetInt32("id_Maqui");
                        }
                    }
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_Maqui", idCliente);

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
