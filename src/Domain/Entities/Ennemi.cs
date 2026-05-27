namespace Domain.Entities;

using Domain.Abstractions;

public class Ennemi(string nom, int pvMax, int attaque, int armure) : IPersonnage
{
    public string Nom { get; } = nom;
    public int PvMax { get; } = pvMax;
    public int PvActuels { get; private set; } = pvMax;
    public int Attaque { get; } = attaque;
    public int Armure { get; } = armure;

    public bool EstVivant => PvActuels > 0;

    public void SubirDegats(int degats) =>
        PvActuels = Math.Max(0, PvActuels - degats);
}
