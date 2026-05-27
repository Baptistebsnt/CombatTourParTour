using CombatTourParTour.Domain.Entities;

namespace CombatTourParTour.Application.Actions;

public class CompetenceAction : ICombatAction
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
        return $"{champion.Nom} utilise sa compétence de {champion.Classe.Nom} sur {cible.Nom} et inflige {degats} dégâts !";
    }
}
