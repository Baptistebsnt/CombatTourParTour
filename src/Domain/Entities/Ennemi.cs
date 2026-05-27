namespace Domain.Entities;

using Domain.Abstractions;

public class Ennemi : IPersonnage
{
    public string Nom { get; }
    public int PvMax { get; }
    public int PvActuels { get; private set; }
    public int Attaque { get; }
    public int Armure { get; }

    public bool EstVivant => PvActuels > 0;

    public Ennemi(string nom, int pvMax, int attaque, int armure)
    {
        Nom = nom;
        PvMax = pvMax;
        PvActuels = pvMax;
        Attaque = attaque;
        Armure = armure;
    }

    public void SubirDegats(int degats) => PvActuels = Math.Max(0, PvActuels - degats);
}
