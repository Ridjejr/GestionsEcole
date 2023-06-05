using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public partial class Form_ListeEleves : Form
    {

        List<Eleve> lesEleves = new List<Eleve>();

        public Form_ListeEleves()
        {
            InitializeComponent();
            RemplirListe();
        }

        public void RemplirListe()
        {
            try
            {
                // dgv_ListeEleves.Rows.Clear();
                lesEleves = ManagerEleve.DonneEleves();
                bs.DataSource= lesEleves;

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
            Eleve EleveSelectionne = new Eleve();
            DataGridViewRow ligne = dgv_ListeEleves.SelectedRows[0];
            EleveSelectionne = ligne.DataBoundItem as Eleve;
            if(EleveSelectionne!=null)
            {
                FicheEleve frm = new FicheEleve(false, EleveSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Eleve EleveSelectionne = new Eleve();
            DataGridViewRow ligne = dgv_ListeEleves.SelectedRows[0];
            EleveSelectionne = ligne.DataBoundItem as Eleve;
            if (EleveSelectionne != null)
            {
                FicheEleve frm = new FicheEleve(true, EleveSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Suppression_Click(object sender, EventArgs e)
        {
            Eleve EleveSelectionne = new Eleve();
            DataGridViewRow ligne = dgv_ListeEleves.SelectedRows[0];
            EleveSelectionne = ligne.DataBoundItem as Eleve;

            bool resultat = ManagerEleve.SupprimerEleve(EleveSelectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            FicheEleve frm = new FicheEleve(true);
            frm.ShowDialog();
            RemplirListe();
        }
    }
}
