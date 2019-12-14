using System;
using System.Collections.Generic;
using System.Linq;

namespace jurassic_csharp
{
  class Program
  {
    static List<Dinosaur> NumOfDino = new List<Dinosaur>();
    static void DinosInPark()
    {
      NumOfDino.AddRange(new List<Dinosaur> {
        new Dinosaur
        {
          Name = "T-Rex",
          DietType = "Carnivore",
          DateAcquired = DateTime.Parse("04/23/2001"),
          Weight = 1500,
          EnclosureNumber = 1
        },
        new Dinosaur {
            Name = "Sauropods",
            DietType = "Herbivore",
            DateAcquired = DateTime.Parse ("01/04/1999"),
            Weight = 789,
            EnclosureNumber = 2
        },

            new Dinosaur {
                Name = "Megalosaurus",
                DietType = "Carinovre",
                DateAcquired = DateTime.Parse ("12/4/1998"),
                Weight = 900,
                EnclosureNumber = 3
            },

             new Dinosaur {
                Name = "Reidosaur",
                DietType = "Herbivore",
                DateAcquired = DateTime.Parse ("11/15/2000"),
                Weight = 1200,
                EnclosureNumber = 4
             },

            new Dinosaur {
              Name = "Titanosaurus",
              DietType = "Herbivore",
              DateAcquired = DateTime.Parse ("9/17/1993"),
              Weight = 2000,
              EnclosureNumber = 5
            },

       new Dinosaur {
          Name = "Velociraptor",
          DietType = "Carnivore",
          DateAcquired = DateTime.Parse ("1/30/1998"),
          Weight = 450,
          EnclosureNumber = 6
        }
      });
    }
    static void AddDino()
    {
      Console.WriteLine("Enter Name of new Dinosaur for the park");
      var dinoName = Console.ReadLine();
      Console.WriteLine("Is it a carnivore or herbivore?");
      var dietType = Console.ReadLine();
      Console.WriteLine("When did the Dino enter the park?");
      var dinoDate = Console.ReadLine();
      Console.WriteLine("How much does the Dino weigh?");
      var dinoWeight = Console.ReadLine();
      Console.WriteLine("What numeric enclosure will they be in?");
      var enclosure = Console.ReadLine();

      var dino = new Dinosaur();
      dino.Name = dinoName;
      dino.DateAcquired = DateTime.Now;
      dino.DietType = dietType;
      dino.Weight = int.Parse(dinoWeight);
      dino.EnclosureNumber = int.Parse(enclosure);

      NumOfDino.Add(dino);
    }

    static void ViewAll()
    {
      DisplayListOfDinosaur(NumOfDino);

    }

    static void DisplayListOfDinosaur(IEnumerable<Dinosaur> NumOfDino)
    {
      Console.WriteLine("Displaying: Current Dinosaurs in the park");
      Console.WriteLine("-----------");
      foreach (var dino in NumOfDino.OrderBy(dino => dino.DateAcquired))
      {
        Console.WriteLine($"{dino.Name} is currently in the park at Enclosure Number {dino.EnclosureNumber}");
        Console.WriteLine($"{dino.Name} is a {dino.DietType}, weighs in at {dino.Weight} pounds, and joined the park on {dino.DateAcquired}");
      }
    }





    static void Main(string[] args)
    {
      DinosInPark();
      Console.WriteLine("Welcome to the Jurrasic CSharp App!");
      var input = "";
      while (input != "quit")
      {
        Console.WriteLine("Here you can view all the dinos with -displayAll-, enter info for a new dino with -add-, remove a dino with -deleteDino-, transfer enclousres with -transfer-, sort by weight or diet using, -heavyDino- or -diet-");
        input = Console.ReadLine().ToLower();
        if (input == "add")
        {
          AddDino();
        }

      }
      )
    }

  }
};

