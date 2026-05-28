namespace CombatTourParTour.Application.Etats;

using CombatTourParTour.Application.Ports;

public class DefaiteEtat(IServicesAffichage services) : ICombatEtat
{
    public void Entrer(CombatContexte contexte)
    {
        services.Resultat.AfficherDefaite();
        contexte.EstTermine = true;
    }

    public void Executer(CombatContexte contexte) { }
}
