namespace CombatTourParTour.Application.Ports;

public interface IServicesAffichage
{
    IAffichageCombat Combat { get; }
    IMenuJoueur Menu { get; }
    IAffichageResultat Resultat { get; }
    IAffichageTourEnnemi TourEnnemi { get; }
}
