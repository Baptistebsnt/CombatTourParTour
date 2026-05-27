using CombatTourParTour.Application.Factories;
using Domain.Entities;

IChampionFactory championFactory = new ChampionFactory();

Console.WriteLine("Nom de votre champion : ");
string nom = Console.ReadLine() ?? "Héros";

Console.WriteLine("Classes : {0}", string.Join(", ", championFactory.ClasseDisponibles));
Console.WriteLine("Choisissez une classe : ");
string choix = Console.ReadLine() ?? "guerrier";

Champion champion = championFactory.CreerChampion(nom, choix);
