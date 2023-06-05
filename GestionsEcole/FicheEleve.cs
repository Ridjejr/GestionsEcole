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
    public partial class FicheEleve : Form
    {

        private int numEleve;

        Eleve EleveCourant  = new Eleve();
        public FicheEleve(bool modification, Eleve monEleve=null)
        {
            InitializeComponent();
            try
            {
                if(monEleve!= null) 
                {
                    EleveCourant = monEleve;
                }
                bs.DataSource = EleveCourant;

                if(modification==false)
                {
                    text_Nom.Enabled=false;
                    text_Prenom.Enabled=false;
                    text_Sexe.Enabled=false;
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
                    if (EleveCourant.Id_eleve == 0) // cas d'un ajout
                    {
                        EleveCourant = bs.Current as Eleve;
                        bool reponse = ManagerEleve.AjouterEleve(EleveCourant);
                    }
                    else // cas modification
                    {
                        EleveCourant = bs.Current as Eleve;
                        bool reponse = ManagerEleve.ModifierEleve(EleveCourant);
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
            if (text_Nom.Text == "") {
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