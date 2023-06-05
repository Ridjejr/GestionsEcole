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
    public partial class Form_FicheProfesseur : Form
    {
        private int numProfesseur;

        Professeur ProfesseurCourant = new Professeur();
        public Form_FicheProfesseur(bool modification, Professeur monProfesseur = null)
        {
            InitializeComponent();
            try
            {
                if (monProfesseur != null)
                {
                    ProfesseurCourant = monProfesseur;
                }
                bs.DataSource = ProfesseurCourant;

                if (modification == false)
                {
                    text_Nom.Enabled = false;
                    text_Prenom.Enabled = false;
                    text_Sexe.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (ProfesseurCourant.Id_prof == 0) // cas d'un ajout
                    {
                        ProfesseurCourant = bs.Current as Professeur;
                        bool reponse = ManagerProfesseur.AjouterProfesseur(ProfesseurCourant);
                    }
                    else // cas modification
                    {
                        ProfesseurCourant = bs.Current as Professeur;
                        bool reponse = ManagerProfesseur.ModifierProfesseur(ProfesseurCourant);
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
            if (text_Nom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un mom");
                controle = false;
            }
            if (text_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }

            if (text_Sexe.Text == "")
            {
                MessageBox.Show("Vous devez saisir un sexe");
                controle = false;
            }
            return controle;
        }
    }

}
