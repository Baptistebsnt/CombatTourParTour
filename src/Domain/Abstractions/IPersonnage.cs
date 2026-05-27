namespace CombatTourParTour.Domain.Abstractions;

public interface IPersonnage
{
    string Nom { get; }
    int PvMax { get; }
    int PvActuels { get; }
    bool EstVivant { get; }
    void SubirDegats(int degats);
}
