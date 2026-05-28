using CombatTourParTour.Domain.Entities;

namespace CombatTourParTour.Application.Commandes;

public class ActionInvoker
{
    private readonly Dictionary<int, ICommande> _commandes = [];

    public void Enregistrer(int touche, ICommande commande) =>
        _commandes[touche] = commande;

    public bool PeutExecuter(int touche, Champion champion) =>
        _commandes.TryGetValue(touche, out var cmd) && cmd.PeutExecuter(champion);

    public void Executer(int touche, Champion champion, Ennemi cible)
    {
        if (!_commandes.TryGetValue(touche, out var commande))
        {
            Console.WriteLine(" Choix invalide. ");
            return;
        }

        if (!commande.PeutExecuter(champion))
        {
            Console.WriteLine($"    {commande.Nom} n'est pas disponible.");
            return;
        }

        commande.Executer(champion, cible);
    }

    public void AfficherMenu(Champion champion)
    {
        Console.WriteLine("\n Actions :");
        foreach (var (touche, commande) in _commandes)
        {
            string disponible = commande.PeutExecuter(champion) ? "" : " (indisponible)";
            Console.WriteLine($"  {touche} : {commande.Nom}{disponible}");
        }
        Console.WriteLine();
    }
}
