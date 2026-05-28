namespace CombatTourParTour.Application.Ports;

using CombatTourParTour.Application.Etats;

public interface IAffichageCombat
{
    void AfficherEtat(CombatContexte contexte);
}
