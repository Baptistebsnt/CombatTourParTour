namespace CombatTourParTour.Application.Actions;

using CombatTourParTour.Domain.Entities;
using CombatTourParTour.Application.Events;

public class CompetenceAction(CombatPublie combatPublie) : ICombatAction
{
    public string Nom => "Compétence spéciale de classe";

    public bool PeutRealiser(Champion champion) => champion.CooldownRestant == 0;

    public string Realiser(Champion champion, Ennemi cible)
    {
        int degats = Math.Max(
            1,
            champion.Classe.CalculerDegatsCompetence(champion.Classe.AttaqueDeBase, cible.Armure)
        );

        cible.SubirDegats(degats);
        champion.AppliquerCooldown();

        combatPublie.Publier(new CombatEvenement(
            TypeEvenement.DegatsInfliges,
            $"{champion.Nom} utilise sa compétence de {champion.Classe.Nom} sur {cible.Nom} et inflige {degats} dégâts !"
        ));

        if (!cible.EstVivant)
            combatPublie.Publier(new CombatEvenement(
                TypeEvenement.PersonnageVaincu,
                $"{cible.Nom} est vaincu !"
            ));

        return string.Empty;
    }
}
