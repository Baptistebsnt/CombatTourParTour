namespace CombatTourParTour.Application.Ports;

public interface IAffichageTourEnnemi
{
    void AfficherAttaque(string nomEnnemi, string nomChampion, int degats);
    void AfficherTourDebut();
}
