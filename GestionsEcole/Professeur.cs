using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionsEcole
{
    public class Professeur
    {
        private int id_prof;
        private string nom;
        private string prenom;
        private string sexe;

        public int Id_prof { get => id_prof; set => id_prof = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom;
        }
    }
}
