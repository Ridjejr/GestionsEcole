﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public class ManagerProfesseur
    {
        public static Professeur DonneProfesseurDuReader(MySqlDataReader monReader) // element dans la base de données 
        {
            Professeur unProfesseur = new Professeur();
            unProfesseur.Id_prof = Convert.ToInt16(monReader["id_prof"]);
            unProfesseur.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            unProfesseur.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
            unProfesseur.Sexe = monReader["sexe"] == DBNull.Value ? "" : monReader["sexe"] as string;
            return unProfesseur;
        }

        public static List<Professeur> DonneProfesseurs(bool orderByNom = false)
        {
            List<Professeur> lesProfesseurs = new List<Professeur>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;

            Connection.MaConnection.Open();   // Ouvre la connection
            maRequete = Connection.MaConnection.CreateCommand(); // declaration d'une requête 

            if (orderByNom)
            {
                maRequete.CommandText = "SELECT * FROM ¨Professeur ORDER BY Nom"; // Trié par nom
            }
            else
            {
                maRequete.CommandText = "SELECT * FROM Professeur ORDER BY id_prof"; // Trié par identifiant
            }

            //maRequete.CommandText = "select * from Professeur order by Nom, Prenom";
            monReader = maRequete.ExecuteReader();  // execution de la requête

            while (monReader.Read())
            {
                Professeur unProfesseur = ManagerProfesseur.DonneProfesseurDuReader(monReader);
                lesProfesseurs.Add(unProfesseur);
            }

            monReader.Close();
            Connection.MaConnection.Close();

            return lesProfesseurs;

        }

        public static Professeur DonneProfesseurParId(int id)
        {
            MySqlConnection connection = Connection.NewConnection();
            MySqlCommand maRequete = connection.CreateCommand();
            MySqlDataReader monReader; // Element lu de la requête

            maRequete.CommandText = "select * from Professeur " +
                "where id_prof=@paramId_prof";

            maRequete.Parameters.AddWithValue("@paramId_prof", id);
            connection.Open();
            monReader = maRequete.ExecuteReader();
            monReader.Read();
            Professeur unProfesseur = DonneProfesseurDuReader(monReader);
            connection.Close();

            return unProfesseur;
        }

        public static bool ModifierProfesseur(Professeur e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            maRequete.CommandText = "update Professeur set " +
                "Nom=@paramNom, Prenom=@paramPrenom, sexe=@paramSexe where id_prof=@paramId_prof";

            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramNom", e.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", e.Prenom);
            maRequete.Parameters.AddWithValue("@paramSexe", e.Sexe);
            maRequete.Parameters.AddWithValue("@paramId_prof", e.Id_prof);

            Connection.MaConnection.Open();
            int result = maRequete.ExecuteNonQuery();
            Connection.MaConnection.Close();

            if (result > 0)
            {
                reponse = true;
            }

            return reponse;
        }

        public static bool AjouterProfesseur(Professeur e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into Professeur (Nom, Prenom, Sexe)" +
                    "Nom=@paramNom, Prenom=@paramPrenom, Sexe=@paramSexe where id_prof=@paramId_prof";
            maRequete.Parameters.Clear();  //annule tous les anciens paramètres

            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramNom", e.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", e.Prenom);
            maRequete.Parameters.AddWithValue("@paramSexe", e.Sexe);
            //maRequete.Parameters.AddWithValue("@paramId_prof", e.Id_prof);
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
                    throw new Exception("Une erreur s'est produite, le professeur n'a pas été mis à jour. ");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static bool SupprimerProfesseur(Professeur e)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from Professeur where id_prof=@paramId_prof";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //supprime les paramètres de la requête de supprimer
            maRequete.Parameters.AddWithValue("@paramId_prof", e.Id_prof);
            string message = "Etes vous sûr de vouloir supprimer le professeur" + e.Nom;
            const string caption = "Supression du professeur";
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
                    throw new Exception("Une erreur s'est produite, le professeur n'a pas été supprimé.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
