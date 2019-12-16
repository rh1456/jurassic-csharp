using System;
using System.Collections.Generic;
using System.Linq;

namespace jurassic_csharp
{
  class Program
  {
    static DinosaurContext Db = new DinosaurContext();

    // {var db = new DinosaurContext();
    //  db.Dinosaurs.Add(new Dinosaur {

    //  }
    // // }
    // static void DinosInPark()
    // {
    //   NumOfDino.AddRange(new List<Dinosaur> {
    //     new Dinosaur
    //     {
    //       Name = "T-Rex",
    //       DietType = "Carnivore",
    //       DateAcquired = DateTime.Parse("04/23/2001"),
    //       Weight = 1500,
    //       EnclosureNumber = 1
    //     },
    //     new Dinosaur {
    //         Name = "Sauropods",
    //         DietType = "Herbivore",
    //         DateAcquired = DateTime.Parse ("01/04/1999"),
    //         Weight = 789,
    //         EnclosureNumber = 2
    //     },

    //         new Dinosaur {
    //             Name = "Megalosaurus",
    //             DietType = "Carinovre",
    //             DateAcquired = DateTime.Parse ("12/4/1998"),
    //             Weight = 900,
    //             EnclosureNumber = 3
    //         },

    //          new Dinosaur {
    //             Name = "Reidosaur",
    //             DietType = "Herbivore",
    //             DateAcquired = DateTime.Parse ("11/15/2000"),
    //             Weight = 1200,
    //             EnclosureNumber = 4
    //          },

    //         new Dinosaur {
    //           Name = "Titanosaurus",
    //           DietType = "Herbivore",
    //           DateAcquired = DateTime.Parse ("9/17/1993"),
    //           Weight = 2000,
    //           EnclosureNumber = 5
    //         },

    //    new Dinosaur {
    //       Name = "Velociraptor",
    //       DietType = "Carnivore",
    //       DateAcquired = DateTime.Parse ("1/30/1998"),
    //       Weight = 450,
    //       EnclosureNumber = 6
    //     }
    //   });
    // }
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

      Db.Dinosaurs.Add(dino);
      Db.SaveChanges();
    }

    static void ViewAll()
    {
      DisplayListOfDinosaur(Db.Dinosaurs);

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
    // static void RemoveDino()
    // {
    //   Console.WriteLine("Specify the name of dinosaur you are going to remove");
    //   var dinoName = Console.ReadLine();
    //   Db.Dinosaurs.RemoveAll(dino => dino.Name == dinoName);
    // }

    static void TransferDino()
    {
      Console.WriteLine("Who are you moving?");
      var dinoName = Console.ReadLine();
      Console.WriteLine($"Where do you want to move {dinoName} too?");
      var enclosure = Console.ReadLine();
      var changeEnclosure = Db.Dinosaurs.FirstOrDefault(dino => dino.Name.ToLower() == dinoName.ToLower());
      changeEnclosure.EnclosureNumber = int.Parse(enclosure);
    }
    static void SortByWeight()
    {
      Console.WriteLine("Viewing the 3 heaviest dinos we have:");
      Console.WriteLine("-------");
      DisplayListOfDinosaur(Db.Dinosaurs.OrderByDescending(dino => dino.Weight).Take(3));
      Console.WriteLine("---------");
    }
    static void SortByDiet()
    {
      Console.WriteLine("View dinos by diet: herbivore or carnivore?");
      var dinoDietType = Console.ReadLine();
      var dinoDiet = Db.Dinosaurs.Count(dino => dino.DietType.ToLower() == dinoDietType.ToLower());
      Console.WriteLine($"Currently we have {dinoDiet} {dinoDietType}");
    }
    static void QuitApp()
    {
      Console.WriteLine("So long!");
    }
    static void UnknownCommand()
    {
      Console.WriteLine("Unknown Command, Try Again");
    }
    static void ReleaseDino()
    {
      Console.WriteLine("Which Dino would you like to release");
      var dinoName = Console.ReadLine();
      var updateDino = Db.Dinosaurs.FirstOrDefault(dino => dino.EnclosureNumber == int.Parse("---"));
      Db.SaveChanges();
    }
    static void Main(string[] args)
    {

      Console.WriteLine("Welcome to the Jurrasic CSharp App!");
      var input = "";
      while (input != "quit")
      {
        Console.WriteLine("Here you can view all the dinos with -view-, enter info for a new dino with -add-, remove a dino with -delete-, transfer enclousres with -transfer-, sort by weight or diet using, -heavy- or -diet-");
        input = Console.ReadLine().ToLower();

        if (input == "add")
        {
          AddDino();
        }
        else if
          (input == "view")
        {
          ViewAll();
        }
        else if (input == "release")
        {
          ReleaseDino();
        }
        // else if (input == "delete")
        // {
        //   RemoveDino();
        // }
        else if (input == "transfer")
        {
          TransferDino();
        }
        else if (input == "diet")
        {
          SortByDiet();
        }
        else if (input == "heavy")
        {
          SortByWeight();
        }
        else if (input == "quit")
        {
          QuitApp();
        }
        else
        {
          UnknownCommand();
        }
      }
    }

  }

};


