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
    public partial class Form_ListeClasses : Form
    {

        List<Classe> lesClasses = new List<Classe>();

        public Form_ListeClasses()
        {
            InitializeComponent();
            RemplirListe();
        }

        public void RemplirListe()
        {
            try
            {
                // dgv_ListeClasses.Rows.Clear();
                lesClasses = ManagerClasse.DonneClasses();
                bs.DataSource = lesClasses;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Classe ClasseSelectionne = new Classe();
            DataGridViewRow ligne = dgv_ListeClasses.SelectedRows[0];
            ClasseSelectionne = ligne.DataBoundItem as Classe;
            if (ClasseSelectionne != null)
            {
                FicheClasse frm = new FicheClasse(false, ClasseSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Classe ClasseSelectionne = new Classe();
            DataGridViewRow ligne = dgv_ListeClasses.SelectedRows[0];
            ClasseSelectionne = ligne.DataBoundItem as Classe;
            if (ClasseSelectionne != null)
            {
                FicheClasse frm = new FicheClasse(true, ClasseSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Suppression_Click(object sender, EventArgs e)
        {
            Classe ClasseSelectionne = new Classe();
            DataGridViewRow ligne = dgv_ListeClasses.SelectedRows[0];
            ClasseSelectionne = ligne.DataBoundItem as Classe;

            bool resultat = ManagerClasse.SupprimerClasse(ClasseSelectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            FicheClasse frm = new FicheClasse(true);
            frm.ShowDialog();
            RemplirListe();
        }

    }
}
