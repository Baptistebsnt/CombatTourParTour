namespace CombatTourParTour.Application.Etats;

using CombatTourParTour.Application.Ports;
using CombatTourParTour.Application.Events;

public class TourEnnemiEtat(IServicesAffichage services) : ICombatEtat
{
    public void Entrer(CombatContexte contexte) =>
        services.TourEnnemi.AfficherTourDebut();

    public void Executer(CombatContexte contexte)
    {
        foreach (var ennemi in contexte.EnnemisActuels.Where(e => e.EstVivant))
        {
            int degats = Math.Max(1, ennemi.Attaque);
            contexte.Champion.SubirDegats(degats);

            contexte.Publisher.Publier(new CombatEvenement(
                TypeEvenement.DegatsInfliges,
                $"{ennemi.Nom} attaque {contexte.Champion.Nom} et inflige {degats} dégâts."));

            services.TourEnnemi.AfficherAttaque(ennemi.Nom, contexte.Champion.Nom, degats);
        }

        contexte.ChangerEtat(!contexte.Champion.EstVivant
            ? new DefaiteEtat(services)
            : new TourJoueurEtat(services));
    }
}
