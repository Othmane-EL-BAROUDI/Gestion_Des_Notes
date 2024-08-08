using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_notes
{
    public class GestionDesNotes
    {
        private List<Etudiant> etudiants = new List<Etudiant>();
        private List<Cours> coursList = new List<Cours>();
        private List<Notes> notesList = new List<Notes>();

        public void AjouterEtudiant(int idEtudiant, string nom, string prenom)
        {
            Etudiant nouvelEtudiant = new Etudiant(idEtudiant, nom, prenom);
            etudiants.Add(nouvelEtudiant);
            EnregistrerEtudiant(nouvelEtudiant);
        }

        public void AjouterCours(int idCours, string code, string titre)
        {
            Cours nouveauCours = new Cours(idCours, code, titre);
            coursList.Add(nouveauCours);
        }

        public void AjouterNote(int idEtudiant, int idCours, double note)
        {
            Notes nouvelleNote = new Notes(idEtudiant, idCours, note);
            notesList.Add(nouvelleNote);
            EnregistrerNote(nouvelleNote);
        }

        public void AfficherNotes(int idEtudiant)
        {
            var notesEtudiant = notesList.Where(n => n.IdEtudiant == idEtudiant).ToList();

            if (notesEtudiant.Count == 0)
            {
                Console.WriteLine("Aucune note trouvée pour cet étudiant.");
            }
            else
            {
                foreach (var note in notesEtudiant)
                {
                    Console.WriteLine(note.ToString());
                }
            }
        }

        private void EnregistrerEtudiant(Etudiant etudiant)
        {
            string filename = $"etudiant_{etudiant.IdEtudiant}.txt";
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(etudiant.ToString());
            }
        }

        private void EnregistrerNote(Notes note)
        {
            string filename = $"etudiant_{note.IdEtudiant}.txt";
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(note.ToString());
            }
        }
    }
}