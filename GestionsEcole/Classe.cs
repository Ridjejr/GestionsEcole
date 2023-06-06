using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionsEcole
{
    public class Classe
    {
        private int id_classe;
        private string niveau;
        private int id_prof;
        private Professeur leProfesseur;

        public int Id_classe { get => id_classe; set => id_classe = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public int Id_prof { get => id_prof; set => id_prof = value; }
        public Professeur LeProfesseur { get => leProfesseur; set => leProfesseur = value; }
    }
}
