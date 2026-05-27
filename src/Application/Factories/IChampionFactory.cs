using Domain.Entities;

namespace CombatTourParTour.Application.Factories;

public interface IChampionFactory
{
    Champion CreerChampion(string nom, string typeClasse);
    IReadOnlyList<string> ClasseDisponibles { get; }
}
