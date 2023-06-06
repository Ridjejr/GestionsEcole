using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionsEcole
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void elèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeEleves frm = new Form_ListeEleves();
            frm.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeClasses frm = new Form_ListeClasses();
            frm.Show();
        }

        private void professeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeProfesseurs frm = new Form_ListeProfesseurs();
            frm.Show();
        }

        private void matièreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeMatieres frm = new Form_ListeMatieres();
            frm.Show();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeNotes frm = new Form_listeNotes();
            frm.Show();
        }

        private void enseignantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeEnseigner frm = new Form_listeEnseigner();
            frm.Show();
        }
    }
}