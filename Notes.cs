using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_notes
{
    public class Notes
    {
        public int IdEtudiant { get; set; }
        public int IdCours { get; set; }
        public double Note { get; set; }

        public Notes(int idEtudiant, int idCours, double note)
        {
            IdEtudiant = idEtudiant;
            IdCours = idCours;
            Note = note;
        }

        public override string ToString()
        {
            return $"Étudiant: {IdEtudiant}, Cours: {IdCours}, Note: {Note}";
        }
    }
}