namespace Application.Actions;

using Domain.Entities;

public interface ICombatAction
{
    string Nom { get; }
    bool PeutRealiser(Champion champion);
    string Realiser(Champion champion, Ennemi ennemi);
}
