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
    public partial class Form_FicheMatiere : Form
    {
        private int numMatiere;

        Matiere MatiereCourant = new Matiere();
        public Form_FicheMatiere(bool modification, Matiere monMatiere = null)
        {
            InitializeComponent();
            try
            {
                if (monMatiere != null)
                {
                    MatiereCourant = monMatiere;
                }
                bs.DataSource = MatiereCourant;

                if (modification == false)
                {
                    text_Nom.Enabled = false;
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
                    if (MatiereCourant.Id_matiere == 0) // cas d'un ajout
                    {
                        MatiereCourant = bs.Current as Matiere;
                        bool reponse = ManagerMatiere.AjouterMatiere(MatiereCourant);
                    }
                    else // cas modification 
                    {
                        MatiereCourant = bs.Current as Matiere;
                        bool reponse = ManagerMatiere.ModifierMatiere(MatiereCourant);
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
                MessageBox.Show("Vous devez saisir le mom d'une matière");
                controle = false;
            }
            return controle;
        }
    }
}
