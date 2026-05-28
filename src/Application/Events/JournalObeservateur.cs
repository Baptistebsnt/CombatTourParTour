namespace CombatTourParTour.Application.Events;

public class JournalObservateur : ICombatOberservateur
{
    private readonly List<string> _historique = [];
    private const int NombresEntreeAfficher = 5;

    public IReadOnlyList<string> Historique => _historique.AsReadOnly();

    public void OnEvenement(CombatEvenement evenement)
    {
        _historique.Add($"[{evenement.Type}] {evenement.Message}");
    }

    public IEnumerable<string> ObtenirDernieresEvenements() =>
    _historique.TakeLast(NombresEntreeAfficher);
}
