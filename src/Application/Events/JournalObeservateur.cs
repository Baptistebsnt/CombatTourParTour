namespace CombatTourParTour.Application.Events;

public class JournalObservateur : ICombatOberservateur
{
    private readonly List<string> _historique = new();
    private const int NombresEntreeAfficher = 5;

    public IReadOnlyList<string> Historique => _historique.AsReadOnly();

    public void OnEvenement(CombatEvenement evenement)
    {
        _historique.Add($"[{evenement.Type}] {evenement.Message}");
    }

    public IEnumerable<string> ObtenirDernieresEntrees() =>
    _historique.TakeLast(NombresEntreeAfficher);
}
