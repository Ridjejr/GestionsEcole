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
    public partial class FicheClasse : Form
    {
        //private int numClasse;

        Classe ClasseCourant = new Classe();
        public FicheClasse(bool modification, Classe monClasse = null)
        {
            InitializeComponent();
            bsProfesseur.DataSource = ManagerProfesseur.DonneProfesseurs(true); // Professeur par nom

            try
            {
                if (monClasse != null)
                {
                    ClasseCourant = monClasse; // Affecter la classe courant par la classe passé en paramètre

                    // pour chaque professeur
                    foreach ( Professeur p in comboProfesseur.Items)
                    {
                        // Si le professeur principal de la classe
                        if (ClasseCourant.LeProfesseur.Id_prof == p.Id_prof)
                        {
                            // Le selectionner par défaut
                            comboProfesseur.SelectedItem = p;
                            break; // Stopper la boucle
                        }

                    }
                }
                // Sinon (cas d'une création)
                else
                {
                    lb_id_Classe.Visible = false; 
                    text_Id_classe.Visible = false;

                    // fix de l'ereur quand on veux créer une nouvelle classe sans changer le professeur
                    ClasseCourant.LeProfesseur = (Professeur) comboProfesseur.SelectedItem;
                }
                bs.DataSource = ClasseCourant;

                if (modification == false)
                {
                    text_Niveau.Enabled = false;
                    text_Id_classe.Enabled = false;
                    comboProfesseur.Enabled = false;
                    btn_Valider.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Fermer le formulaire
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (ClasseCourant.Id_classe == 0) // cas d'un ajout
                    {
                        ClasseCourant = bs.Current as Classe;
                        bool reponse = ManagerClasse.AjouterClasse(ClasseCourant);

                        if (reponse == true)
                        {
                            MessageBox.Show("La classe a bien été ajouté.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Une erreur s'est produite, la classe n'a pas été ajouté.");
                        }

                    }
                    else // cas modification
                    {
                        ClasseCourant = bs.Current as Classe;
                        bool reponse = ManagerClasse.ModifierClasse(ClasseCourant);

                        if (reponse == true)
                        {
                            MessageBox.Show("La classe a bien été modifié.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Une erreur s'est produite, la classe n'a pas été modifié.");
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ControleSaisies()
        {
            bool controle = true;
            if (text_Niveau.Text == "")
            {
                MessageBox.Show("Vous devez saisir un niveau");
                controle = false;
            }
            return controle;
        }

    }
}
