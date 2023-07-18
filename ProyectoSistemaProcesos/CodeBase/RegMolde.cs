using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class RegMolde
    {
        public RegMolde() 
        { 

        }
        public RegMolde(string name)
        {

        }
        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=BDDSistemProc;uid=root;password=abcd1234;";
        public void registrarMolde(object[] obj)
        {
            try
            {
                string ci = "";
                string query = "select nom_TMold from TipoMolde where nom_TMold=@nom_TMold;";
                string query1 = "INSERT INTO TipoMolde (nom_TMold) VALUES (@nom_TMold);";
                string query2 = "select nom_TMold from TipoMolde where nom_TMold=@nom_TMold;";
                string query3= "INSERT INTO TipoMolde (nom_TMold) VALUES (@nom_TMold);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@CI_Maqui", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ci = reader.GetString("CI_Maqui");
                        }
                    }
                }
                if (ci != obj[0].ToString())
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
    }
}
