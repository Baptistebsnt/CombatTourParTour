IChampionFactory championFactory = new ChampionFactory();

Console.WriteLine("Nom de votre champion : ");
string nom = Console.ReadLine();

Console.WriteLine("Classes : {0}", string.Join(", ", championFactory.ClasseDisponibles));
Console.WriteLine("Choisissez une classe : ");
string choix = Console.ReadLine();

Champion champion = championFactory.CreerChampion(nom, choix);