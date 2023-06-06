using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestionsEcole
{
    public class ManagerEnseigner
    {
        public static Enseigner DonneEnseignerDuReader(MySqlDataReader monReader) // element dans la base de données 
        {
            Enseigner unEnseignant = new Enseigner();

            // Si le niveau est null, mettre chaine de caractère vide, sinon mettre le niveau 
            unEnseignant.LaMatiere = ManagerMatiere.DonneMatiereParId(Convert.ToInt16(monReader["id_matiere"]));
            unEnseignant.LeProfesseur = ManagerProfesseur.DonneProfesseurParId(Convert.ToInt16(monReader["id_prof"]));

            return unEnseignant;
        }

        public static List<Enseigner> DonneEnseigners()
        {
            List<Enseigner> lesEnseigners = new List<Enseigner>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();   // Ouvre la connection
            maRequete = Connection.MaConnection.CreateCommand(); // declaration d'une requête 
            maRequete.CommandText = "select * from enseigner";
            monReader = maRequete.ExecuteReader();  // execution de la requête

            while (monReader.Read())
            {
                Enseigner unEnseignant = ManagerEnseigner.DonneEnseignerDuReader(monReader);
                lesEnseigners.Add(unEnseignant);
            }

            monReader.Close();
            Connection.MaConnection.Close();

            return lesEnseigners;

        }

        public static Enseigner DonneEnseignerParId(int id)
        {
            Enseigner unEnseignant = new Enseigner();
            return unEnseignant;
        }

        public static bool ModifierEnseigner(Enseigner e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "update enseigner set " +
                "id_matiere=@paramId_matiere, id=prof=@paramId_prof";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramId_matiere", e.LaMatiere.Id_matiere);
            maRequete.Parameters.AddWithValue("@paramId_prof", e.LeProfesseur.Id_prof);

            Connection.OpenConnection();
            int result = maRequete.ExecuteNonQuery();
            Connection.CloseConnection();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;
        }

        public static bool AjouterEnseigner(Enseigner e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "insert into enseigner (id_matiere, id_prof) " +
                "VALUES(@paramMatiere, @paramProfesseur)";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramMatiere", e.LaMatiere.Id_matiere);
            maRequete.Parameters.AddWithValue("@paramProfesseur", e.LeProfesseur.Id_prof );

            Connection.MaConnection.Open();
            int result = maRequete.ExecuteNonQuery();
            Connection.MaConnection.Close();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;

        }

    }
}
