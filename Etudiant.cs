namespace Gestion_des_notes
{
    public class Etudiant
    {
        public int IdEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Etudiant(int idEtudiant, string nom, string prenom)
        {
            IdEtudiant = idEtudiant;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return $"{IdEtudiant} - {Nom} {Prenom}";
        }
    }
}