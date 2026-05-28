namespace CombatTourParTour.Application.Etats;

using CombatTourParTour.Application.Ports;

public class VictoireEtat(IServicesAffichage services) : ICombatEtat
{
    public void Entrer(CombatContexte contexte)
    {
        services.Resultat.AfficherVictoire();
        contexte.EstTermine = true;
    }

    public void Executer(CombatContexte contexte) { }
}
