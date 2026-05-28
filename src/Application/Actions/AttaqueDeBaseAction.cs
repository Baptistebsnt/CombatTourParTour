namespace CombatTourParTour.Application.Actions;

using CombatTourParTour.Application.Events;
using CombatTourParTour.Domain.Entities;

public class AttaqueDeBaseAction(CombatPublie combatPublie) : ICombatAction
{
    public string Nom => "Attaque de base";

    public bool PeutRealiser(Champion champion) => true;

    public string Realiser(Champion champion, Ennemi cible)
    {
        int degats = Math.Max(1, champion.Classe.AttaqueDeBase - cible.Armure);
        cible.SubirDegats(degats);

        combatPublie.Publier(new CombatEvenement(
            TypeEvenement.DegatsInfliges,
            $"{champion.Nom} attaque {cible.Nom} et inflige {degats} dégâts."
        ));

        if (!cible.EstVivant)
            combatPublie.Publier(new CombatEvenement(
                TypeEvenement.PersonnageVaincu,
                $"{cible.Nom} est vaincu !"
            ));

        return string.Empty;
    }
}
