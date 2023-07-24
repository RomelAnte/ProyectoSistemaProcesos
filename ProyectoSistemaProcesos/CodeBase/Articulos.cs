using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class Articulos
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Material { get; set; }
        public string categoria { get; set; };
        public string FechAdquisicion { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public bool Estado { get; set; }

        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=bddsistemproc;uid=root;password=magenkiosharingan123;";
        public void registrar()
        {
            string codigo = "";
            try
            {
                string query1 = "select codigo_Art from Articulos where codigo_Art=@codigo_Art;";
                string query = "INSERT INTO Articulos (codigo_Art, nom_Art, cantidad_Art, material_Art, color_Art, costo_Art, FechAdquisicion_Art, descripcion_Art, E_Art) VALUES (@codigo_Art, @nom_Art, @cantidad_Art, @material_Art, @color_Art, @costo_Art, @FechAdquisicion_Art, @descripcion_Art, @E_Art);";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, _connection))
                {
                    command.Parameters.AddWithValue("@codigo_Art", this.Codigo);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigo = reader.GetString("codigo_Art");
                        }
                    }
                }
                if (codigo != this.Codigo)
                {
                    using (MySqlCommand command = new MySqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@codigo_Art", this.odigo);
                        command.Parameters.AddWithValue("@nom_Art", this.Nombre);
                        command.Parameters.AddWithValue("@cantidad_Art", this.Cantidad);
                        command.Parameters.AddWithValue("@material_Art", this.Material);
                        command.Parameters.AddWithValue("@FechAdquisicion_Art", this.FechAdquisicion);
                        command.Parameters.AddWithValue("@color_Art", this.Color);
                        command.Parameters.AddWithValue("@descripcion_Art", this.Descripcion);
                        command.Parameters.AddWithValue("@costo_Art", this.Costo);
                        command.Parameters.AddWithValue("@E_Art", this.Estado);
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
                    MessageBox.Show("El Articulo ya existe en la base de datos");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }

        public bool Buscar(int val)
        {
            try
            {
                if (val == 1)
                {
                    string query1 = "select codigo_Art, nom_Art, cantidad_Art, material_Art, color_Art, costo_Art, FechAdquisicion_Art, descripcion_Art, E_Art from Articulos where codigo_Art=@codigo_Art;";
                    using (MySqlConnection _connection = new MySqlConnection(connectionString))
                    {
                        _connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query1, _connection))
                        {
                            command.Parameters.AddWithValue("@codigo_Art", this.Codigo);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    this.Codigo = reader.GetString("codigo_Art");
                                    this.Nombre = reader.GetString("nom_Art");
                                    this.Cantidad = reader.GetInt32("cantidad_Art");
                                    this.Material = reader.GetString("material_Art");
                                    this.FechAdquisicion = reader.GetString("FechAdquisicion_Art");
                                    this.Color = reader.GetString("color_Art");
                                    this.Descripcion = reader.GetString("descripcion_Art");
                                    this.Costo = reader.GetDouble("costo_Art");
                                    this.Estado = reader.GetBoolean("E_Art");
                                }
                            }
                        }
                        _connection.Close();
                    }
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
            return false;
        }

        public void Actualizar(int val)
        {
            int idArticulo = -1;
            try
            {
                if (val == 1)
                {
                    string query1 = "SELECT id_Art FROM Articulos WHERE codigo_Art = @codigo_Art;";
                    string query = "UPDATE Articulos SET  codigo_Art = @codigo_Art ,nom_Art = @nom_Art, cantidad_Art = @cantidad_Art, " +
                        "material_Art = @material_Art, FechAdquisicion_Art = @FechAdquisicion_Art, color_Art = @color_Art, descripcion_Art = @descripcion_Art, E_Art = @E_Art  WHERE id_Art = @id_Art;";
                    _connection.ConnectionString = connectionString;
                    _connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, _connection))
                    {
                        command.Parameters.AddWithValue("@codigo_Art", this.Codigo);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idArticulo = reader.GetInt32("id_Art");
                            }
                        }
                    }

                    if (idArticulo != -1)
                    {
                        using (MySqlCommand command = new MySqlCommand(query, _connection))
                        {
                            command.Parameters.AddWithValue("@codigo_Art", this.Codigo);
                            command.Parameters.AddWithValue("@nom_Art", this.Nombre);
                            command.Parameters.AddWithValue("@cantidad_Art", this.Cantidad);
                            command.Parameters.AddWithValue("@material_Art", this.Material);
                            command.Parameters.AddWithValue("@FechAdquisicion_Art", this.FechAdquisicion);
                            command.Parameters.AddWithValue("@color_Art", this.Color);
                            command.Parameters.AddWithValue("@descripcion_Art", this.Descripcion);
                            command.Parameters.AddWithValue("@costo_Art", this.Costo);
                            command.Parameters.AddWithValue("@E_Art", this.Estado);
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
                        MessageBox.Show("No se encontró el Articulo");
                        Console.WriteLine();
                    }
                    _connection.Close();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }

        public void Eliminar(int val)
        {
            int idArticulo = -1;
            try
            {
                if (val == 1)
                {
                    string query1 = "SELECT id_Art FROM Articulos WHERE codigo_Art = @codigo_Art;";
                    string query = "DELETE FROM Articulos WHERE id_Art = @id_Art";
                    _connection.ConnectionString = connectionString;
                    _connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, _connection))
                    {
                        command.Parameters.AddWithValue("@codigo_Art", this.Codigo);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idArticulo = reader.GetInt32("id_Art");
                            }
                        }
                    }
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_Art", idArticulo);

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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.ToString());
            }
        }
    }
}