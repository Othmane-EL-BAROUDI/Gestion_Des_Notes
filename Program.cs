using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_notes
{
    public class Program
    {
        private static GestionDesNotes gestionDesNotes = new GestionDesNotes();

        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AjouterEtudiant();
                        break;
                    case "2":
                        AjouterCours();
                        break;
                    case "3":
                        AjouterNote();
                        break;
                    case "4":
                        AfficherReleveEvaluation();
                        break;
                    case "5":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                        break;
                }
            }

            Console.WriteLine("Merci d'avoir utilisé l'application de gestion des notes. À bientôt !");
        }

        static void AfficherMenu()
        {
            Console.WriteLine("\n--- Menu Principal ---");
            Console.WriteLine("1---- Ajouter un étudiant");
            Console.WriteLine("2---- Ajouter un cours");
            Console.WriteLine("3---- Ajouter une note");
            Console.WriteLine("4---- Afficher le relevé de notes d'un étudiant");
            Console.WriteLine("5---- Quitter");
            Console.Write("Choisissez une option et appuyez sur Entrée : ");
        }

        static void AjouterEtudiant()
        {
            Console.WriteLine("Ajouter un étudiant");
            int idEtudiant = DemanderEntier("Entrez l'ID de l'étudiant : ");
            string nomEtudiant = DemanderChaine("Entrez le nom de l'étudiant : ");
            string prenomEtudiant = DemanderChaine("Entrez le prénom de l'étudiant : ");

            gestionDesNotes.AjouterEtudiant(idEtudiant, nomEtudiant, prenomEtudiant);
            Console.WriteLine("Étudiant ajouté avec succès !");
        }

        static void AjouterCours()
        {
            Console.WriteLine("Ajouter un cours");
            int idCours = DemanderEntier("Entrez l'ID du cours : ");
            string codeCours = DemanderChaine("Entrez le code du cours : ");
            string titreCours = DemanderChaine("Entrez le titre du cours : ");

            gestionDesNotes.AjouterCours(idCours, codeCours, titreCours);
            Console.WriteLine("Cours ajouté avec succès !");
        }

        static void AjouterNote()
        {
            Console.WriteLine("Ajouter une note");
            int idEtudiant = DemanderEntier("Entrez l'ID de l'étudiant : ");
            int idCours = DemanderEntier("Entrez l'ID du cours : ");
            double note = DemanderDouble("Entrez la note : ");

            gestionDesNotes.AjouterNote(idEtudiant, idCours, note);
            Console.WriteLine("Note ajoutée avec succès !");
        }

        static void AfficherReleveEvaluation()
        {
            Console.WriteLine("Afficher le relevé de notes");
            int idEtudiant = DemanderEntier("Entrez l'ID de l'étudiant : ");
            gestionDesNotes.AfficherNotes(idEtudiant);
        }

        static int DemanderEntier(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int resultat))
                {
                    return resultat;
                }
                else
                {
                    Console.WriteLine("Erreur : veuillez entrer un nombre entier valide.");
                }
            }
        }

        static double DemanderDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double resultat))
                {
                    return resultat;
                }
                else
                {
                    Console.WriteLine("Erreur : veuillez entrer un nombre décimal valide.");
                }
            }
        }

        static string DemanderChaine(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
