namespace CombatTourParTour.Infrastructure.Affichage;

using CombatTourParTour.Application.Ports;
using CombatTourParTour.Application.Etats;

public class AffichageCombat : IAffichageCombat
{
    public void AfficherEtat(CombatContexte contexte)
    {
        Console.WriteLine($"\n══════════════════════════════════════");
        Console.WriteLine($"  VAGUE {contexte.VagueCourante + 1}/3 — Tour du joueur");
        Console.WriteLine($"══════════════════════════════════════");
        Console.WriteLine($"  {contexte.Champion.Nom} ({contexte.Champion.Classe.Nom}) " +
                          $"PV : {contexte.Champion.PvActuels}/{contexte.Champion.PvMax}");
        Console.WriteLine($"  Cooldown : {contexte.Champion.CooldownRestant} tour(s)");
        Console.WriteLine("\n  Ennemis :");
        foreach (var ennemi in contexte.EnnemisActuels.Where(e => e.EstVivant))
            Console.WriteLine($"    {ennemi.Nom} PV : {ennemi.PvActuels}/{ennemi.PvMax}");
    }
}
