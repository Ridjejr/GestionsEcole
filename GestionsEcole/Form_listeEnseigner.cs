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
    public partial class Form_listeEnseigner : Form
    {
        List<Enseigner> lesEnseignants = new List<Enseigner>();
        public Form_listeEnseigner()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                lesEnseignants = ManagerEnseigner.DonneEnseigners();
                bs.DataSource = lesEnseignants;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
