namespace CombatTourParTour.Application.Events;

public class ConsoleObservateur : ICombatOberservateur
{
    public void OnEvenement(CombatEvenement evenement)
    {
        Console.WriteLine($"   -> {evenement.Message}");
    }
}
