public class Voleur : IClasseChampions
{
    public string Nom => "Voleur";
    public int PvParDefaut => 90;
    public int AttaqueDeBase => 14;
    public int CooldownEnTour => 2;

    private const double ChanceDeCritique = 0.30;
    private static readonly Random _rng = new();

    public int CalculerDegatsCompetence(int attaqueDeBase, int armureEnemie)
    {
        bool estCritique = _rng.NextDouble() < ChanceDeCritique;
        return estCritique ? attaqueDeBase * 2 : attaqueDeBase;
    }
}