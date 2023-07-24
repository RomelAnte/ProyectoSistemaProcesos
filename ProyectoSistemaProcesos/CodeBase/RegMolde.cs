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
                string id = "";
                string query = "select nom_TMold from TipoMolde where nom_TMold=@nom_TMold;";
                string query1 = "INSERT INTO TipoMolde (nom_TMold) VALUES (@nom_TMold);";
                string query2 = "select id_TMold from TipoMolde where nom_TMold=@nom_TMold;";
                string query3= "INSERT INTO Molde (color_Mold,Talla_Mold,Cantidad_Mold,precio_Mold,TotalC_Mold,fkid_TMold)"+
                    "VALUES (@color_Mold,@Talla_Mold,@Cantidad_Mold,@precio_Mold,@TotalC_Mold,@fkid_TMold);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@nom_TMold", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ci = reader.GetString("nom_TMold");
                        }
                    }
                }
                if (ci != obj[0].ToString())
                {
                    using (MySqlCommand command = new MySqlCommand(query1, _connection))
                    {
                        command.Parameters.AddWithValue("@nom_TMold", obj[0]);
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
                }
                else
                {
                    MessageBox.Show("El empleado ya existe en la base de datos");
                }
                using (MySqlCommand command = new MySqlCommand(query2, _connection))
                {
                    command.Parameters.AddWithValue("@nom_TMold", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetString("id_TMold");
                        }
                    }
                }
                using (MySqlCommand command = new MySqlCommand(query3, _connection))
                {
                    command.Parameters.AddWithValue("@color_Mold", obj[1]);
                    command.Parameters.AddWithValue("@Talla_Mold", obj[2]);
                    command.Parameters.AddWithValue("@Cantidad_Mold", obj[3]);
                    command.Parameters.AddWithValue("@precio_Mold", obj[4]);
                    command.Parameters.AddWithValue("@TotalC_Mold", obj[5]);
                    command.Parameters.AddWithValue("@fkid_TMold",id);
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
    }
}
