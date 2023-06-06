using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionsEcole
{
    public class Eleve
    {
        private int id_eleve;
        private string nom = "";
        private string prenom = "";
        private string sexe = "";

        public int Id_eleve { get => id_eleve; set => id_eleve = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom;
        }
    }
}
