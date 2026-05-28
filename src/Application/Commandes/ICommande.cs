namespace CombatTourParTour.Application.Commandes;

using CombatTourParTour.Domain.Entities;

public interface ICommande
{
    string Nom { get; }
    bool PeutExecuter(Champion champion);
    void Executer(Champion champion, Ennemi cible);
}
