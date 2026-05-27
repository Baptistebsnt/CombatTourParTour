public class ChampionFactory : IChampionFactory
{
    private readonly Dictionary<string, Func<IClasseChampions>> _classesDisponibles = new()
    {
        ["guerrier"] = () => new Guerrier(),
        ["mage"] = () => new Mage(),
        ["voleur"] = () => new Voleur()
    };

    public IReadOnlyList<string> ClasseDisponibles => _classesDisponibles.Keys.ToList().AsReadOnly();

    public Champion CreerChampion(string nom, string typeClasse)
    {
      if (!_classesDisponibles.TryGetValue(typeClasse.ToLower(), out var constructeurClasse))
        {
            throw new ArgumentException($"Classe '{typeClasse}' non reconnue. Classes disponibles : {string.Join(", ", ClasseDisponibles)}");
        }
        return new Champion(nom, constructeurClasse());
    }   
}