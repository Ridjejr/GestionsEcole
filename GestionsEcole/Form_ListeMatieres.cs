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
    public partial class Form_ListeMatieres : Form
    {
        List<Matiere> lesMatieres = new List<Matiere>();

        public Form_ListeMatieres()
        {
            InitializeComponent();
            RemplirListe();
        }

        public void RemplirListe()
        {
            try
            {
                // dgv_ListeMatieres.Rows.Clear();
                lesMatieres = ManagerMatiere.DonneMatieres();
                bs.DataSource = lesMatieres;

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
            Matiere MatiereSelectionne = new Matiere();
            DataGridViewRow ligne = dgv_ListeMatieres.SelectedRows[0];
            MatiereSelectionne = ligne.DataBoundItem as Matiere;
            if (MatiereSelectionne != null)
            {
                Form_FicheMatiere frm = new Form_FicheMatiere(false, MatiereSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Matiere MatiereSelectionne = new Matiere();
            DataGridViewRow ligne = dgv_ListeMatieres.SelectedRows[0];
            MatiereSelectionne = ligne.DataBoundItem as Matiere;
            if (MatiereSelectionne != null)
            {
                Form_FicheMatiere frm = new Form_FicheMatiere(true, MatiereSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Suppression_Click(object sender, EventArgs e)
        {
            Matiere MatiereSelectionne = new Matiere();
            DataGridViewRow ligne = dgv_ListeMatieres.SelectedRows[0];
            MatiereSelectionne = ligne.DataBoundItem as Matiere;

            bool resultat = ManagerMatiere.SupprimerMatiere(MatiereSelectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            Form_FicheMatiere frm = new Form_FicheMatiere(true);
            frm.ShowDialog();
            RemplirListe();
        }

    }
}
