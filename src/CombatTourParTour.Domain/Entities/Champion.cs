public class Champion
{
    public string Nom { get; set; }
    public IClasseChampions Classe { get; set; }
    public int PvMax { get; }
    public int PvActuels { get; set; }
    public int CooldownRestant { get; set; }

    public Champion(string nom, IClasseChampions classe)
    {
        Nom = nom;
        Classe = classe;
        PvMax = classe.PvParDefaut;
        PvActuels = PvMax;
        CooldownRestant = 0;
    }

    public bool EstVivant() => PvActuels > 0;
}