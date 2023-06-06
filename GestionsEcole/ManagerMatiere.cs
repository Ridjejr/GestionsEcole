using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public class ManagerMatiere
    {
        public static Matiere DonneMatiereDuReader(MySqlDataReader monReader) // element dans la base de données 
        {
            Matiere unMatiere = new Matiere();
            unMatiere.Id_matiere = Convert.ToInt16(monReader["id_matiere"]);
            unMatiere.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            return unMatiere;
        }

        public static List<Matiere> DonneMatieres(bool orderByNom = false)
        {
            List<Matiere> lesMatieres = new List<Matiere>();

            MySqlCommand maRequete;
            MySqlDataReader monReader; // Element lu de la requête
            maRequete = Connection.MaConnection.CreateCommand(); // declaration d'une requête 

            Connection.OpenConnection(); // Ouvre la connexion 
            maRequete = Connection.MaConnection.CreateCommand();

            if (orderByNom)
            {
                maRequete.CommandText = "SELECT * FROM Matiere ORDER BY nom"; // Trié par nom
            }
            else
            {
                maRequete.CommandText = "SELECT * FROM Matiere ORDER BY id_matiere"; // Trié par num
            }

            //maRequete.CommandText = "select * from Matiere order by id_matiere";
            monReader = maRequete.ExecuteReader();  // execution de la requête

            while (monReader.Read())
            {
                Matiere unMatiere = ManagerMatiere.DonneMatiereDuReader(monReader);
                lesMatieres.Add(unMatiere);
            }
            monReader.Close();
            Connection.MaConnection.Close();

            return lesMatieres;
        }

        public static Matiere DonneMatiereParId(int id)
        {
            MySqlConnection connection = Connection.NewConnection();
            MySqlCommand maRequete = connection.CreateCommand();
            MySqlDataReader monReader; // Element lu de la requête

            maRequete.CommandText = "select * from Matiere " +
                "where id_matiere=@paramId_matiere";

            maRequete.Parameters.AddWithValue("@paramId_matiere", id);
            connection.Open();
            monReader = maRequete.ExecuteReader();
            monReader.Read();
            Matiere unAuteur = DonneMatiereDuReader(monReader);
            connection.Close();

            return unAuteur;
        }

        public static bool ModifierMatiere(Matiere e)
        {
            bool resulat = true;
            return resulat;
        }

        public static bool AjouterMatiere(Matiere e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into Matiere set " +
                    "Nom=@paramNom, where id_matiere=@paramId_matiere";
            maRequete.Parameters.Clear();  //annule tous les anciens paramètres

            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramNom", e.Nom);
            maRequete.Parameters.AddWithValue("@paramId_matiere", e.Id_matiere);
            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    reponse = true;
                    return reponse;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite, le Matiere n'a pas été mis à jour. ");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static bool SupprimerMatiere(Matiere e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from Matiere where id_matiere=@paramId_matiere";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //supprime les paramètres de la requête de supprimer
            maRequete.Parameters.AddWithValue("@paramId_matiere", e.Id_matiere);
            string message = "Etes vous sûr de vouloir supprimer la Matiere" + e.Nom;
            const string caption = "Supression de la Matiere";
            var result = MessageBox.Show(message, caption,
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    reponse = true;
                    return reponse;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite, la Matiere n'a pas été supprimé.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
