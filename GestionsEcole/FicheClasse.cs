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
        private int numClasse;

        Classe ClasseCourant = new Classe();
        public FicheClasse(bool modification, Classe monClasse = null)
        {
            InitializeComponent();
            try
            {
                if (monClasse != null)
                {
                    ClasseCourant = monClasse;
                }
                bs.DataSource = ClasseCourant;

                if (modification == false)
                {
                    text_Niveau.Enabled = false;
                    text_Id_classe.Enabled = false;
                    text_Id_prof.Enabled = false;
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
                    if (ClasseCourant.Id_classe == 0) // cas d'un ajout
                    {
                        ClasseCourant = bs.Current as Classe;
                        bool reponse = ManagerClasse.AjouterClasse(ClasseCourant);
                    }
                    else // cas modification
                    {
                        ClasseCourant = bs.Current as Classe;
                        bool reponse = ManagerClasse.ModifierClasse(ClasseCourant);
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
