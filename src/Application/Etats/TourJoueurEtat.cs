namespace CombatTourParTour.Application.Etats;

using CombatTourParTour.Application.Ports;
using CombatTourParTour.Application.Events;

public class TourJoueurEtat(IServicesAffichage services) : ICombatEtat
{
    public void Entrer(CombatContexte contexte) =>
        services.Combat.AfficherEtat(contexte);

    public void Executer(CombatContexte contexte)
    {
        int choix = services.Menu.LireChoix(contexte.Champion);
        if (choix == -1) return;

        var cible = contexte.EnnemisActuels.FirstOrDefault(e => e.EstVivant);
        if (cible is null) return;

        contexte.Invoker.Executer(choix, contexte.Champion, cible);
        contexte.Champion.DecrementerCooldown();

        if (contexte.EnnemisActuels.All(e => !e.EstVivant))
        {
            contexte.Publisher.Publier(new CombatEvenement(
                TypeEvenement.VagueTerminee,
                $"Vague {contexte.VagueCourante + 1} terminée !"));

            contexte.ChangerEtat(contexte.VagueCourante >= contexte.Vagues.Count - 1
                ? new VictoireEtat(services)
                : new EntreVaguesEtat(services));
        }
        else
        {
            contexte.ChangerEtat(new TourEnnemiEtat(services));
        }
    }
}
