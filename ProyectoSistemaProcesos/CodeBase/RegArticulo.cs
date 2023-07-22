using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class RegArticulo
    {
        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=BDDSistemProc;uid=root;password=magenkiosharingan123;";

        public void registrarArticulo(object[] obj)
        {
            try
            {
                string codigo = "";
                string query1 = "select id_Art from Articulos where id_Art=@id_Art;";
                string query = "INSERT INTO Articulos (id_Art, nom_Art, cantidad_Art, material_Art, color_Art, costo_Art, FechAdquisicion_Art, descripcion_Art) VALUES (@id_Art, @nom_Art, @cantidad_Art, @material_Art, @color_Art, @costo_Art, @FechAdquisicion_Art, @descripcion_Art);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@id_Art", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigo = reader.GetString("id_Art");
                        }
                    }
                }
                if (codigo != obj[0].ToString())
                {
                    using (MySqlCommand command = new MySqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@nom_Art", obj[1]);
                        command.Parameters.AddWithValue("@cantidad_Art", obj[2]);
                        command.Parameters.AddWithValue("@id_Art", obj[0]);
                        command.Parameters.AddWithValue("@material_Art", obj[3]);
                        command.Parameters.AddWithValue("@color_Art", obj[4]);
                        command.Parameters.AddWithValue("@costo_Art", obj[5]);
                        command.Parameters.AddWithValue("@FechAdquisicion_Art", obj[6]);
                        command.Parameters.AddWithValue("@descripcion_Art", obj[7]);
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }




        }

    
    }
}
