public interface IClasseChampions
{
    string Nom { get; }
    int PvParDefaut { get; }
    int AttaqueDeBase { get; }
    int CooldownEnTour { get; }

    int CalculerDegatsCompetence(int attaqueDeBase, int armureEnemie);
}
