namespace CombatTourParTour.Application.Etats;

using CombatTourParTour.Application.Ports;

public class EntreVaguesEtat(IServicesAffichage services) : ICombatEtat
{
    private const double PourcentageRestoration = 0.20;

    public void Entrer(CombatContexte contexte)
    {
        int soin = (int)Math.Ceiling(contexte.Champion.PvMax * PourcentageRestoration);
        contexte.Champion.SeSoignerDe(soin);
        services.Resultat.AfficherEntreVagues(soin);
    }

    public void Executer(CombatContexte contexte)
    {
        contexte.VagueCourante++;
        contexte.ChangerEtat(new TourJoueurEtat(services));
    }
}
