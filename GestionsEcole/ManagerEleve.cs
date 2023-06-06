using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public class ManagerEleve
    {
        public static Eleve DonneEleveDuReader(MySqlDataReader monReader) // element dans la base de données 
        {
            Eleve unEleve = new Eleve();
            unEleve.Id_eleve = Convert.ToInt16(monReader["id_eleve"]);
            unEleve.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            unEleve.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
            unEleve.Sexe = monReader["sexe"] == DBNull.Value ? "" : monReader["sexe"] as string;
            return unEleve;
        }

        public static List<Eleve> DonneEleves(bool orderByNom = false)
        {
            List<Eleve> lesEleves = new List<Eleve>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();   // Ouvre la connection
            maRequete = Connection.MaConnection.CreateCommand(); // declaration d'une requête 

            if (orderByNom)
            {
                maRequete.CommandText = "SELECT * FROM Eleve ORDER BY nom"; // Trié par nom
            }
            else
            {
                maRequete.CommandText = "SELECT * FROM Eleve ORDER BY id_eleve"; // Trié par num
            }

            //maRequete.CommandText = "select * from Eleve order by Nom, Prenom";
            monReader = maRequete.ExecuteReader();  // execution de la requête

            while (monReader.Read())
            {
                Eleve unEleve = ManagerEleve.DonneEleveDuReader(monReader);
                lesEleves.Add(unEleve);
            }
            monReader.Close();
            Connection.MaConnection.Close();

            return lesEleves;

        }

        public static Eleve DonneEleveParId(int id)
        {
            MySqlConnection connection = Connection.NewConnection();
            MySqlCommand maRequete = connection.CreateCommand();
            MySqlDataReader monReader; // Element lu de la requête

            maRequete.CommandText = "select * from Eleve where id_eleve=@paramId_eleve";
            maRequete.Parameters.AddWithValue("@paramId_eleve", id);
            connection.Open();
            monReader = maRequete.ExecuteReader();
            monReader.Read();
            Eleve unEleve = DonneEleveDuReader(monReader);
            connection.Close();

            return unEleve;
        }

        public static bool ModifierEleve(Eleve e)
        {
            bool resulat = true;
            return resulat;
        }

        public static bool AjouterEleve(Eleve e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into Eleve set " +
                    "Nom=@paramNom, Prenom=@paramPrenom, Sexe=@paramSexe where id_eleve=@paramId_eleve";
            maRequete.Parameters.Clear();  //annule tous les anciens paramètres

            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramNom", e.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", e.Prenom);
            maRequete.Parameters.AddWithValue("@paramSexe", e.Sexe);
            maRequete.Parameters.AddWithValue("@paramId_eleve", e.Id_eleve);
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
                    throw new Exception("Une erreur s'est produite, l'élève n'a pas été mis à jour. ");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static bool SupprimerEleve(Eleve e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from Eleve where id_eleve=@paramId_eleve";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //supprime les paramètres de la requête de supprimer
            maRequete.Parameters.AddWithValue("@paramId_eleve", e.Id_eleve);
            string message = "Etes vous sûr de vouloir supprimer l'élève " + e.Nom;
            const string caption = "Supression de l'élève";
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
                    throw new Exception("Une erreur s'est produite, l'élève n'a pas été supprimé.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
