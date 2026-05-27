using Domain.Entities;

namespace Application.Factories;

public interface IChampionFactory
{
    Champion CreerChampion(string nom, string typeClasse);
    IReadOnlyList<string> ClasseDisponibles { get; }
}
