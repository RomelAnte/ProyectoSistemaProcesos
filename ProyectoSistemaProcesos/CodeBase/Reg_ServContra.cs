using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class Reg_ServContra
    {
        List<string> nombres = new List<string>();
        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=bddsistemproc;uid=root;password=abcd1234;";
        public List<string> ObtenerNombresDesdeBD()
        {                    
            try
            {
                string consulta = "SELECT nom_Maqui, apell_Maqui FROM Maquiladores;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dato = reader["nom_Maqui"].ToString()+" "+reader["apell_Maqui"].ToString(); // Reemplaza "columna" con el nombre de la columna que deseas obtener.
                                nombres.Add(dato);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nombres;
        }
        public void registrar(object [] obj)
        {
            try
            {
                string ci = "";
                string id = "";
                string query = "SELECT id_Maqui FROM Maquiladores where nom_Maqui=@nom_Maqui;";
                string query1 = "SELECT id_Mold FROM Molde where fkid_TMold=@fkid_TMold;";
                string query2 = "select id_TMold from TipoMolde where nom_TMold=@nom_TMold;";
                string query3 = "INSERT INTO Molde (color_Mold,Talla_Mold,Cantidad_Mold,precio_Mold,TotalC_Mold,fkid_TMold)" +
                    "VALUES (@color_Mold,@Talla_Mold,@Cantidad_Mold,@precio_Mold,@TotalC_Mold,@fkid_TMold);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@nom_Maqui", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ci = reader.GetString("nom_Maqui");
                        }
                    }
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
                MessageBox.Show(id);
                using (MySqlCommand command = new MySqlCommand(query3, _connection))
                {
                    command.Parameters.AddWithValue("@color_Mold", obj[1]);
                    command.Parameters.AddWithValue("@Talla_Mold", obj[2]);
                    command.Parameters.AddWithValue("@Cantidad_Mold", obj[3]);
                    command.Parameters.AddWithValue("@precio_Mold", obj[4]);
                    command.Parameters.AddWithValue("@TotalC_Mold", obj[5]);
                    command.Parameters.AddWithValue("@fkid_TMold", id);
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

            }
        }
    }
}
