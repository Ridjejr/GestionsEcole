using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionsEcole
{
    public class Enseigner
    {
        private Matiere laMatiere;
        private Professeur leProfesseur;

        public Matiere LaMatiere { get => laMatiere; set => laMatiere = value; }
        public Professeur LeProfesseur { get => leProfesseur; set => leProfesseur = value; }
    }
}
