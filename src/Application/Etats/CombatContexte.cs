namespace CombatTourParTour.Application.Etats;

using CombatTourParTour.Domain.Entities;
using CombatTourParTour.Application.Commandes;
using CombatTourParTour.Application.Events;
using CombatTourParTour.Application.Ports;

public class CombatContexte
{
    public Champion Champion { get; }
    public List<List<Ennemi>> Vagues { get; }
    public CombatPublie Publisher { get; }
    public ActionInvoker Invoker { get; }
    public JournalObservateur Journal { get; }
    public IServicesAffichage Services { get; }

    public int VagueCourante { get; set; } = 0;
    public List<Ennemi> EnnemisActuels => Vagues[VagueCourante];
    public bool EstTermine { get; set; } = false;

    private ICombatEtat _etatCourant;

    public CombatContexte(
        Champion champion,
        List<List<Ennemi>> vagues,
        CombatPublie publisher,
        ActionInvoker invoker,
        JournalObservateur journal,
        IServicesAffichage services)
    {
        Champion = champion;
        Vagues = vagues;
        Publisher = publisher;
        Invoker = invoker;
        Journal = journal;
        Services = services;
        _etatCourant = new TourJoueurEtat(services);
        _etatCourant.Entrer(this);
    }

    public void ChangerEtat(ICombatEtat nouvelEtat)
    {
        _etatCourant = nouvelEtat;
        _etatCourant.Entrer(this);
    }

    public void Executer() => _etatCourant.Executer(this);
}
