namespace CombatTourParTour.Application.Commandes;

using CombatTourParTour.Domain.Entities;
using CombatTourParTour.Application.Events;

public class JournalCommande(JournalObservateur journal) : ICommande
{
    public string Nom => "Afficher le journal";

    public bool PeutExecuter(Champion champion) => true;

    public void Executer(Champion champion, Ennemi cible)
    {
        Console.WriteLine("\n  ── Journal de combat ──");
        foreach (var message in journal.ObtenirDernieresEvenements())
        {
            Console.WriteLine($"  {message}");
        }
        Console.WriteLine();
    }
}
