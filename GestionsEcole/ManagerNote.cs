using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public class ManagerNote
    {
        public static Note DonneNoteDuReader(MySqlDataReader monReader)
        {
            Note uneNote = new Note();

            uneNote.Id_note = Convert.ToInt32(monReader["id_note"]);

            // Si la valeur est null, mettre chaine de caractère vide, sinon mettre la valeur
            uneNote.Valeur = monReader["valeur"] == DBNull.Value ? "" : monReader["valeur"].ToString();

            uneNote.LEleve = ManagerEleve.DonneEleveParId(Convert.ToInt16(monReader["id_eleve"]));

            uneNote.LaMatiere = ManagerMatiere.DonneMatiereParId(Convert.ToInt16(monReader["id_matiere"]));

            // Retourner le Note
            return uneNote;
        }

        public static List<Note> DonneNotes()
        {
            List<Note> lesNotes = new List<Note>();
            MySqlCommand maRequete;
            MySqlDataReader monReader; // Element lu de la requête

            Connection.OpenConnection(); // Ouvre la connexion 
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "SELECT * FROM Note ORDER BY id_note";
            monReader = maRequete.ExecuteReader();

            while (monReader.Read())
            {
                Note uneNote = DonneNoteDuReader(monReader);
                lesNotes.Add(uneNote);
            }

            monReader.Close();
            Connection.CloseConnection();

            return lesNotes;
        }

        public static Note DonneNoteParId(int id)
        {
            Note uneNote = new Note();
            return uneNote;
        }

        public static bool ModifierNote(Note n)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "update Note set " +
                "Valeur=@paramValeur, id_eleve=@paramEleve, id_matiere=@paramMatiere where id_note=@paramId_note";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramValeur", n.Valeur);
            maRequete.Parameters.AddWithValue("@paramEleve", n.LEleve.Id_eleve);
            maRequete.Parameters.AddWithValue("@paramMatiere", n.LaMatiere.Id_matiere);
            maRequete.Parameters.AddWithValue("@paramId_note", n.Id_note);


            Connection.OpenConnection();
            int result = maRequete.ExecuteNonQuery();
            Connection.CloseConnection();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;
        }

        public static bool AjouterNote(Note n)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "insert into Note (Valeur, id_eleve, id_matiere) " +
                "VALUES(@paramValeur, @paramEleve, @paramMatiere)";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramValeur", n.Valeur);
            maRequete.Parameters.AddWithValue("@paramEleve", n.LEleve.Id_eleve);
            maRequete.Parameters.AddWithValue("@paramMatiere", n.LaMatiere.Id_matiere);

            Connection.OpenConnection();
            int result = maRequete.ExecuteNonQuery();
            Connection.CloseConnection();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;
        }

        public static bool SupprimerNote(Note l)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "delete from Note where " +
                "id_note=@paramId_note";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramId_note", l.Id_note);

            Connection.OpenConnection();
            int result = maRequete.ExecuteNonQuery();
            Connection.CloseConnection();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;
        }
    }
}
