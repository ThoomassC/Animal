using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Animal.Models
{
    public class BDD
    {
        public BDD(string name, string rarity, string type)
        {
            Name = name;
            Rarity = rarity;
            Type = type;
        }

        public string Name { get; protected set; }

        public string Rarity { get; set; }

        public string Type { get; set; }

        public void ConnectionDataBase()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Animal;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            try
            { 
                connection.Open();
                Console.WriteLine("La connexion à la base de données a réussi.");

                Console.WriteLine("Etat : " + connection.State);

                string insert = $"INSERT INTO TableAnimal (name, rarity, type) VALUES ('{Name}', '{Rarity}', '{Type}')";
                SqlCommand insertCommand = new SqlCommand(insert, connection);
                insertCommand.ExecuteNonQuery();

                string select = "SELECT * FROM TableAnimal";
                SqlCommand selectCommand = new SqlCommand(select, connection);
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["id"] + " " + reader["name"] + " " + reader["rarity"] + " " + reader["type"]);
                }

                int rowsAffected = insertCommand.ExecuteNonQuery();
                Console.WriteLine("{0} ligne(s) insérée(s).", rowsAffected);

                reader.Close();
                connection.Close();
                Console.WriteLine("Etat : " + connection.State);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connexion fermée.");
            }
        }
    }
}