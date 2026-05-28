namespace CombatTourParTour.Application.Events;

public interface ICombatOberservateur
{
    void OnEvenement(CombatEvenement evenement);
}
