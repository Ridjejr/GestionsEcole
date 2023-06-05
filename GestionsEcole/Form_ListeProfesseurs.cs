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
    public partial class Form_ListeProfesseurs : Form
    {
        List<Professeur> lesProfesseurs = new List<Professeur>();

        public Form_ListeProfesseurs()
        {
            InitializeComponent();
            RemplirListe();
        }

        public void RemplirListe()
        {
            try
            {
                // dgv_ListeProfesseurs.Rows.Clear();
                lesProfesseurs = ManagerProfesseur.DonneProfesseurs();
                bs.DataSource = lesProfesseurs;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            {

            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Professeur ProfesseurSelectionne = new Professeur();
            DataGridViewRow ligne = dgv_ListeProfesseurs.SelectedRows[0];
            ProfesseurSelectionne = ligne.DataBoundItem as Professeur;
            if (ProfesseurSelectionne != null)
            {
                Form_FicheProfesseur frm = new Form_FicheProfesseur(false, ProfesseurSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Professeur ProfesseurSelectionne = new Professeur();
            DataGridViewRow ligne = dgv_ListeProfesseurs.SelectedRows[0];
            ProfesseurSelectionne = ligne.DataBoundItem as Professeur;
            if (ProfesseurSelectionne != null)
            {
                Form_FicheProfesseur frm = new Form_FicheProfesseur(true, ProfesseurSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Suppression_Click(object sender, EventArgs e)
        {
            Professeur ProfesseurSelectionne = new Professeur();
            DataGridViewRow ligne = dgv_ListeProfesseurs.SelectedRows[0];
            ProfesseurSelectionne = ligne.DataBoundItem as Professeur;

            bool resultat = ManagerProfesseur.SupprimerProfesseur(ProfesseurSelectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            Form_FicheProfesseur frm = new Form_FicheProfesseur(true);
            frm.ShowDialog();
            RemplirListe();
        }
    }
}
