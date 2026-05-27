namespace CombatTourParTour.Application.Actions;

using CombatTourParTour.Domain.Entities;

public class SoinAction : ICombatAction
{
    private const int SoinParUtilisation = 25;
    private const int UtilisationMax = 2;

    public string Nom => "Se soigner";

    private int _utilisationsRestantes = UtilisationMax;
    public int UtilisationRestantes => _utilisationsRestantes;

    public bool PeutRealiser(Champion champion) => _utilisationsRestantes > 0;

    public string Realiser(Champion champion, Ennemi cible)
    {
        champion.SeSoignerDe(SoinParUtilisation);
        _utilisationsRestantes--;
        return $"{champion.Nom} se soigne de {SoinParUtilisation} PV. ({UtilisationRestantes} soin(s) restant(s))";
    }
}
