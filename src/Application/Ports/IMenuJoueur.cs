namespace CombatTourParTour.Application.Ports;

using CombatTourParTour.Domain.Entities;

public interface IMenuJoueur
{
    int LireChoix(Champion champion);
}
