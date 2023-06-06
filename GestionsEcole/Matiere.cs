using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionsEcole
{
    public class Matiere
    {
        private int id_matiere;
        private string nom;

        public int Id_matiere { get => id_matiere; set => id_matiere = value; }
        public string Nom { get => nom; set => nom = value; }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
