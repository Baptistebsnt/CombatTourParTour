namespace CombatTourParTour.Application.Commandes;

using CombatTourParTour.Domain.Entities;
using CombatTourParTour.Application.Actions;

public class CompetenceCommande(CompetenceAction action) : ICommande
{
    public string Nom => action.Nom;

    public bool PeutExecuter(Champion champion) => action.PeutRealiser(champion);

    public void Executer(Champion champion, Ennemi cible) =>
        action.Realiser(champion, cible);
}
