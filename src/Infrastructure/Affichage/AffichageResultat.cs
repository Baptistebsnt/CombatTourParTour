namespace CombatTourParTour.Infrastructure.Affichage;

using CombatTourParTour.Application.Ports;

public class AffichageResultat : IAffichageResultat
{
    public void AfficherVictoire()
    {
        Console.WriteLine("\n══════════════════════════════════════");
        Console.WriteLine("  VICTOIRE ! Vous avez vaincu tous les ennemis !");
        Console.WriteLine("══════════════════════════════════════");
    }

    public void AfficherDefaite()
    {
        Console.WriteLine("\n══════════════════════════════════════");
        Console.WriteLine("  DÉFAITE... Vous avez été vaincu.");
        Console.WriteLine("══════════════════════════════════════");
    }

    public void AfficherEntreVagues(int soin)
    {
        Console.WriteLine($"\n  Vague terminée ! Vous récupérez {soin} PV.");
        Console.WriteLine("  Préparez-vous pour la prochaine vague...\n");
    }
}
