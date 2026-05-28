namespace CombatTourParTour.Application.Events;

public class CombatPublie
{
    private readonly List<ICombatOberservateur> _observateurs = new();

    public void Abonner(ICombatOberservateur observateur) =>
        _observateurs.Add(observateur);

    public void Desabonner(ICombatOberservateur observateur) =>
        _observateurs.Remove(observateur);

    public void Publier(CombatEvenement evenement)
    {
        foreach (var observateur in _observateurs)
            observateur.OnEvenement(evenement);
    }

}
