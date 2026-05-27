namespace CombatTourParTour.Domain.Entities;

using CombatTourParTour.Domain.Abstractions;

public class Champion : IPersonnage
{
    public string Nom { get; set; }
    public IClasseChampions Classe { get; set; }
    public int PvMax { get; }
    public int PvActuels { get; set; }
    public int CooldownRestant { get; set; }
    public bool EstVivant => PvActuels > 0;

    public Champion(string nom, IClasseChampions classe)
    {
        Nom = nom;
        Classe = classe;
        PvMax = classe.PvParDefaut;
        PvActuels = PvMax;
        CooldownRestant = 0;
    }

    public void SubirDegats(int degats)
    {
        PvActuels = Math.Max(0, PvActuels - degats);
    }

    public void SeSoignerDe(int soins)
    {
        PvActuels = Math.Min(PvMax, PvActuels + soins);
    }

    public void DecrementerCooldown()
    {
        if (CooldownRestant > 0)
            CooldownRestant--;
    }

    public void AppliquerCooldown()
    {
        CooldownRestant = Classe.CooldownEnTour;
    }
}
