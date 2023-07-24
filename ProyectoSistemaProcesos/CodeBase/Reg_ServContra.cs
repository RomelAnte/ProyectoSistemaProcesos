using MySql.Data.MySqlClient;
using ProyectoSistemaProcesos.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaProcesos.CodeBase
{
    public class Reg_ServContra:ServContra
    {
        ServContra servContra = new ServContra();
        List<string> nombres = new List<string>();
        Form_Moldes form_Moldes = new Form_Moldes();
        MySqlConnection _connection = new MySqlConnection();
        string connectionString = "server=localhost;database=bddsistemproc;uid=root;password=abcd1234;";
        public Reg_ServContra()
        {

        }
        public Reg_ServContra(ServContra servContra)
        {   
            this.servContra = servContra;
            MessageBox.Show(Convert.ToString(tipo));
        }
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
                                string dato = reader["nom_Maqui"].ToString()+" "+reader["apell_Maqui"].ToString();
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
                string val = "";
                string query = "SELECT id_Maqui FROM Maquiladores where nom_Maqui=@nom_Maqui;";
                string query1 = "SELECT id_Mold FROM Molde where fkid_TMold=@fkid_TMold;";
                string query2 = "select id_TMold from TipoMolde where nom_TMold=@nom_TMold;";
                _connection.ConnectionString = connectionString;
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@nom_Maqui", obj[0]);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ci = reader.GetString("id_Maqui");
                        }
                    }
                }
                val = servContra.tipo;
                MessageBox.Show(val);
                using (MySqlCommand command = new MySqlCommand(query2, _connection))
                {
                    command.Parameters.AddWithValue("@nom_TMold", val);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32("id_TMold").ToString();
                        }
                    }
                }
                if (!string.IsNullOrEmpty(id))
                {
                    string query3 = "INSERT INTO ServicioMaquilacion (FechaI_SMaqui, FechaF_SMaqui, fkid_Maqui, fkid_Mold )" +
                                    "VALUES (@FechaI_SMaqui, @FechaF_SMaqui, @fkid_Maqui, @fkid_Mold);";
                    using (MySqlCommand command = new MySqlCommand(query3, _connection))
                    {
                        command.Parameters.AddWithValue("@FechaI_SMaqui", obj[1]);
                        command.Parameters.AddWithValue("@FechaF_SMaqui", obj[2]);
                        command.Parameters.AddWithValue("@fkid_Maqui", ci);
                        command.Parameters.AddWithValue("@fkid_Mold", id);

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
                    MessageBox.Show("Tipo de molde no encontrado");
                }
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
