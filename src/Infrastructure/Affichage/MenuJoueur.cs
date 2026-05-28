namespace CombatTourParTour.Infrastructure.Affichage;

using CombatTourParTour.Application.Ports;
using CombatTourParTour.Application.Commandes;
using CombatTourParTour.Domain.Entities;

public class MenuJoueur(ActionInvoker invoker) : IMenuJoueur
{
    public int LireChoix(Champion champion)
    {
        invoker.AfficherMenu(champion);
        Console.Write("\n  Votre choix : ");
        if (int.TryParse(Console.ReadLine(), out int choix))
            return choix;
        Console.WriteLine("  Entrée invalide, veuillez entrer un chiffre.");
        return -1;
    }
}
