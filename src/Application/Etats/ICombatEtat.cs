namespace CombatTourParTour.Application.Etats;

public interface ICombatEtat
{
    void Entrer(CombatContexte contexte);
    void Executer(CombatContexte contexte);
}
