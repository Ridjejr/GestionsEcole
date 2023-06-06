using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public partial class Form_FicheNote : Form
    {
        Note NoteCourant = new Note();
        public Form_FicheNote(bool modification, Note maNote = null)
        {
            InitializeComponent();
            bsEleve.DataSource = ManagerEleve.DonneEleves(true); // Eleves par nom

            bsMatiere.DataSource = ManagerMatiere.DonneMatieres(true); // Matieres par libelle


            try
            {
                // Si le Note n'est pas null (cas de modification ou d'affichage)
                if (maNote != null)
                {
                    NoteCourant = maNote; // Affecter la Note courant par la Note passé en paramètre

                    // Pour chaque eleve
                    foreach (Eleve e in comboEleve.Items)
                    {
                        // Si c'est l'eleve du Note
                        if (NoteCourant.LEleve.Id_eleve == e.Id_eleve)
                        {
                            // Le selectionner par défaut
                            comboEleve.SelectedItem = e;
                            break; // Stopper la boucle
                        }
                    }

                    // Pour chaque matiere
                    foreach (Matiere m in comboMatiere.Items)
                    {
                        // Si c'est le matiere du Note
                        if (NoteCourant.LaMatiere.Id_matiere == m.Id_matiere)
                        {
                            // Le selectionner par défaut
                            comboMatiere.SelectedItem = m;
                            break; // Stopper la boucle
                        }
                    }

                }
                // Sinon (cas d'une création)
                else
                {
                    lb_id_note.Visible = false; // Masquer le label du numéro
                    text_id_note.Visible = false; // Masquer la textbox du numéro


                    NoteCourant.LEleve = (Eleve)comboEleve.SelectedItem;
                    NoteCourant.LaMatiere = (Matiere)comboMatiere.SelectedItem;
                }

                bs.DataSource = NoteCourant; // Note dans le binding source

                // S'il ne s'agit pas d'une modification (ou création)
                if (modification == false)
                {
                    // Griser les champs
                    text_Valeur.Enabled = false;
                    comboEleve.Enabled = false;
                    comboMatiere.Enabled = false;
                    btn_Valider.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Fermer le formulaire
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                // Si le controle de saisie retourne true
                if (ControleSaisie() == true)
                {
                    if (NoteCourant.Id_note == 0) // Cas d'un ajout
                    {
                        NoteCourant = bs.Current as Note; // Définir le Note courant comme 
                        bool reponse = ManagerNote.AjouterNote(NoteCourant);

                        if (reponse == true)
                        {
                            MessageBox.Show("La Note a bien été ajouté.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Une erreur s'est produite, la Note n'a pas été ajouté.");
                        }

                    }
                    else // Cas d'une modification
                    {
                        NoteCourant = bs.Current as Note;
                        bool reponse = ManagerNote.ModifierNote(NoteCourant);

                        if (reponse == true)
                        {
                            MessageBox.Show("La Note a bien été modifié.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Une erreur s'est produite, la Note n'a pas été modifié.");
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Connection.CloseConnection();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private bool ControleSaisie()
        {
            bool controle = true;

            if (text_Valeur.Text == "")
            {
                MessageBox.Show("Vous devez saisir une note.");
                controle = false;
            }
            return controle;
        }
    }
}
