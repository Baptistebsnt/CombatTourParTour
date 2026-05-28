namespace CombatTourParTour.Infrastructure.Affichage;

using CombatTourParTour.Application.Ports;

public class AffichageTourEnnemi : IAffichageTourEnnemi
{
    public void AfficherAttaque(string nomEnnemi, string nomChampion, int degats)
        => Console.WriteLine($"  {nomEnnemi} attaque {nomChampion} et inflige {degats} dégâts.");

    public void AfficherTourDebut()
        => Console.WriteLine("\n  — Tour des ennemis —");
}
