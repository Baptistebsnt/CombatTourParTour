namespace CombatTourParTour.Application.Actions;

using CombatTourParTour.Domain.Entities;
using CombatTourParTour.Application.Events;

public class SoinAction(CombatPublie combatPublie) : ICombatAction
{
    private const int SoinParUtilisation = 25;
    private const int UtilisationMax = 2;

    private int _utilisationsRestantes = UtilisationMax;

    public string Nom => "Se soigner";
    public int UtilisationsRestantes => _utilisationsRestantes;

    public bool PeutRealiser(Champion champion) => _utilisationsRestantes > 0;

    public string Realiser(Champion champion, Ennemi cible)
    {
        champion.SeSoignerDe(SoinParUtilisation);
        _utilisationsRestantes--;

        combatPublie.Publier(new CombatEvenement(
            TypeEvenement.PersonnageSoigne,
            $"{champion.Nom} se soigne de {SoinParUtilisation} PV. ({_utilisationsRestantes} soin(s) restant(s))"
        ));

        return string.Empty;
    }
}
