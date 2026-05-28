using CombatTourParTour.Application.Actions;
using CombatTourParTour.Domain.Entities;

namespace CombatTourParTour.Application.Commandes;

public class SoinCommande(SoinAction soinAction) : ICommande
{
    public string Nom => soinAction.Nom;

    public bool PeutExecuter(Champion champion) => soinAction.PeutRealiser(champion);

    public void Executer(Champion champion, Ennemi cible) =>
        soinAction.Realiser(champion, cible);
}
