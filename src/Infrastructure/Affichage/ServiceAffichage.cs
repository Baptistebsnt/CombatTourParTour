namespace CombatTourParTour.Infrastructure.Affichage;

using CombatTourParTour.Application.Ports;
using CombatTourParTour.Application.Commandes;

public class ServicesAffichage(ActionInvoker invoker) : IServicesAffichage
{
    public IAffichageCombat Combat { get; } = new AffichageCombat();
    public IMenuJoueur Menu { get; } = new MenuJoueur(invoker);
    public IAffichageResultat Resultat { get; } = new AffichageResultat();
    public IAffichageTourEnnemi TourEnnemi { get; } = new AffichageTourEnnemi();
}
