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
    public partial class Form_listeNotes : Form
    {
        List<Note> lesNotes = new List<Note>();

        public Form_listeNotes()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                lesNotes = ManagerNote.DonneNotes();
                bs.DataSource = lesNotes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            private void btn_Afficher_Click(object sender, EventArgs e)
            {
                Note NoteSelectionne = new Note();
                DataGridViewRow ligne = dgv_listeNotes.SelectedRows[0];
                NoteSelectionne = ligne.DataBoundItem as Note;
                if (NoteSelectionne != null)
                {
                    Form_FicheNote frm = new Form_FicheNote(false, NoteSelectionne);
                    frm.ShowDialog();
                }
            }

            private void btn_Modifier_Click(object sender, EventArgs e)
            {
                Note NoteSelectionne = new Note();
                DataGridViewRow ligne = dgv_listeNotes.SelectedRows[0];
                NoteSelectionne = ligne.DataBoundItem as Note;
                if (NoteSelectionne != null)
                {
                    Form_FicheNote frm = new Form_FicheNote(true, NoteSelectionne);
                    frm.ShowDialog();
                }
            }

            private void btn_Supprimer_Click(object sender, EventArgs e)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cette Note ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Note NoteSelectionne = new Note();
                        DataGridViewRow ligne = dgv_listeNotes.SelectedRows[0];
                        NoteSelectionne = ligne.DataBoundItem as Note;
                        if (NoteSelectionne != null)
                        {
                            bool reponse = ManagerNote.SupprimerNote(NoteSelectionne);

                            if (reponse == true)
                            {
                                MessageBox.Show("Le Note a bien été supprimé.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                throw new Exception("Une erreur s'est produite, la Note n'a pas été supprimé.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Connection.CloseConnection();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            private void btn_Nouveau_Click(object sender, EventArgs e)
            {
                Form_FicheNote frm = new Form_FicheNote(true);
                frm.ShowDialog();
            }

    }
}
