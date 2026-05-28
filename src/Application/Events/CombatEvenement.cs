namespace CombatTourParTour.Application.Events;

public enum TypeEvenement
{
    DegatsInfliges,
    PersonnageVaincu,
    PersonnageSoigne,
    VagueTerminee,
}

public record CombatEvenement(
    TypeEvenement Type,
    string Message
);
