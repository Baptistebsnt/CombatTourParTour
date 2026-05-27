namespace CombatTourParTour.Application.Classes;

using CombatTourParTour.Domain.Abstractions;

public class Guerrier : IClasseChampions
{
    public string Nom => "Guerrier";
    public int PvParDefaut => 120;
    public int AttaqueDeBase => 18;
    public int CooldownEnTour => 2;

    public int CalculerDegatsCompetence(int attaqueDeBase, int armureEnemie)
    {
        const double MultiplicateurFrappeLourde = 1.5;
        return (int)(attaqueDeBase * MultiplicateurFrappeLourde) - armureEnemie;
    }
}
