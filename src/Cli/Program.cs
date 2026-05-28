using CombatTourParTour.Domain.Entities;
using CombatTourParTour.Application.Factories;
using CombatTourParTour.Application.Actions;
using CombatTourParTour.Application.Commandes;
using CombatTourParTour.Application.Events;
using CombatTourParTour.Application.Etats;
using CombatTourParTour.Infrastructure.Affichage;

// Observer
var publisher = new CombatPublie();
var journal = new JournalObservateur();
publisher.Abonner(journal);
publisher.Abonner(new ConsoleObservateur());

// Strategy
var attaque = new AttaqueDeBaseAction(publisher);
var competence = new CompetenceAction(publisher);
var soin = new SoinAction(publisher);

// Commande
var invoker = new ActionInvoker();
invoker.Enregistrer(1, new AttaquerCommande(attaque));
invoker.Enregistrer(2, new CompetenceCommande(competence));
invoker.Enregistrer(3, new SoinCommande(soin));
invoker.Enregistrer(4, new JournalCommande(journal));

// Infrastructure
var services = new ServicesAffichage(invoker);

// Factory
IChampionFactory championFactory = new ChampionFactory();

Console.WriteLine("══════════════════════════════════════");
Console.WriteLine("      BIENVENUE DANS COMBAT RPG       ");
Console.WriteLine("══════════════════════════════════════");

Console.Write("\nNom de votre champion : ");
string nom = Console.ReadLine() ?? "Héros";

Console.WriteLine($"\nClasses disponibles : {string.Join(", ", championFactory.ClasseDisponibles)}");
Console.Write("Choisissez une classe : ");
string choix = Console.ReadLine() ?? "guerrier";

Champion champion = championFactory.CreerChampion(nom, choix);
Console.WriteLine($"\nChampion créé : {champion.Nom} ({champion.Classe.Nom})");

// Vagues
var vagues = new List<List<Ennemi>>
{
    new() { new Ennemi("Gobelin", 40, 8, 2) },

    new() { new Ennemi("Gobelin", 40, 8, 2),
                       new Ennemi("Gobelin Archer", 35, 10, 1) },

    new() { new Ennemi("Orc Boss", 120, 20, 8) },
};

// Etats
var contexte = new CombatContexte(champion, vagues, publisher, invoker, journal, services);

while (!contexte.EstTermine)
    contexte.Executer();
