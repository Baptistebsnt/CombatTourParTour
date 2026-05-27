namespace Application.Classes;

using Domain.Abstractions;

public class Mage : IClasseChampions
{
    public string Nom => "Mage";
    public int PvParDefaut => 80;
    public int AttaqueDeBase => 12;
    public int CooldownEnTour => 3;

    private const double ReductionArmure = 0.5;

    public int CalculerDegatsCompetence(int attaqueDeBase, int armureEnemie)
    {
        int armureEffective = (int)(armureEnemie * ReductionArmure);
        return Math.Max(1, attaqueDeBase - armureEffective);
    }
}
