using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public class ManagerClasse
    {
        public static Classe DonneClasseDuReader(MySqlDataReader monReader) // element dans la base de données 
        {
            Classe uneClasse = new Classe();

            uneClasse.Id_classe = Convert.ToInt16(monReader["id_Classe"]);

            // Si le niveau est null, mettre chaine de caractère vide, sinon mettre le niveau 
            uneClasse.Niveau = monReader["niveau"] == DBNull.Value ? "" : monReader["niveau"] as string;
            uneClasse.LeProfesseur = ManagerProfesseur.DonneProfesseurParId(Convert.ToInt16(monReader["id_prof"]));
            
            return uneClasse;
        }

        public static List<Classe> DonneClasses()
        {
            List<Classe> lesClasses = new List<Classe>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();   // Ouvre la connection
            maRequete = Connection.MaConnection.CreateCommand(); // declaration d'une requête 
            maRequete.CommandText = "select * from Classe order by id_classe";
            monReader = maRequete.ExecuteReader();  // execution de la requête

            while (monReader.Read())
            {
                Classe uneClasse = ManagerClasse.DonneClasseDuReader(monReader);
                lesClasses.Add(uneClasse);
            }

            monReader.Close();
            Connection.MaConnection.Close();

            return lesClasses;

        }

        public static Classe DonneClasseParId(int id)
        {
            Classe uneClasse = new Classe();
            return uneClasse;
        }

        public static bool ModifierClasse(Classe e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "update Classe set " +
                "Niveau=@paramNiveau, id_prof=@paramProfesseur where id_Classe=@paramId_Classe";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramNiveau", e.Niveau);
            maRequete.Parameters.AddWithValue("@paramProfesseur", e.LeProfesseur.Id_prof);
            maRequete.Parameters.AddWithValue("@paramId_Classe", e.Id_classe);

            Connection.MaConnection.Open();
            int result = maRequete.ExecuteNonQuery();
            Connection.MaConnection.Close();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;
        }

        public static bool AjouterClasse(Classe e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "insert into Classe (Niveau, id_prof) " +
                "VALUES(@paramNiveau, @paramProfesseur)";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramNiveau", e.Niveau);
            maRequete.Parameters.AddWithValue("@paramProfesseur", e.LeProfesseur.Id_prof);
            //maRequete.Parameters.AddWithValue("@paramId_Classe", e.Id_classe);

            Connection.MaConnection.Open();
            int result = maRequete.ExecuteNonQuery();
            Connection.MaConnection.Close();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;

        }

        public static bool SupprimerClasse(Classe e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from Classe where id_Classe=@paramId_Classe";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //supprime les paramètres de la requête de supprimer
            maRequete.Parameters.AddWithValue("@paramId_Classe", e.Id_classe);
            string message = "Etes vous sûr de vouloir supprimer la classe de " + e.Niveau;
            const string caption = "Supression de la classe";
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
                    throw new Exception("Une erreur s'est produite, la classe n'a pas été supprimé.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
