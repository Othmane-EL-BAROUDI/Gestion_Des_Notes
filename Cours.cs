namespace Gestion_des_notes
{
    public class Cours
    {
        public int IdCours { get; set; }
        public string Code { get; set; }
        public string Titre { get; set; }

        public Cours(int idCours, string code, string titre)
        {
            IdCours = idCours;
            Code = code;
            Titre = titre;
        }

        public override string ToString()
        {
            return $"{IdCours} - {Code} : {Titre}";
        }
    }
}