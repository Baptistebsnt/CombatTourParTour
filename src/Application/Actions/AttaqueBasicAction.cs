namespace Application.Actions;

using Domain.Entities;

public class AttaqueBasicAction : ICombatAction
{
    public string Nom => "Attaque de base";

    public bool PeutRealiser(Champion champion) => true;

    public string Realiser(Champion champion, Ennemi cible)
    {
        int degats = Math.Max(1, champion.Classe.AttaqueDeBase - cible.Armure);
        cible.SubirDegats(degats);
        return $"{champion.Nom} attaque {cible.Nom} et inflige {degats} dégâts.";
    }
}
