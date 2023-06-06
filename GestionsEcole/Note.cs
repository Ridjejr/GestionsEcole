using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionsEcole
{
    public class Note
    {
        private int id_note;
        private string valeur;
        private Eleve lEleve;
        private Matiere laMatiere;

        public int Id_note { get => id_note; set => id_note = value; }
        public string Valeur { get => valeur; set => valeur = value; }
        public Eleve LEleve { get => lEleve; set => lEleve = value; }
        public Matiere LaMatiere { get => laMatiere; set => laMatiere = value; }
    }
}
