using System;
using System.Collections.Generic;
using System.Linq;

namespace jurassic_csharp
{
  class Program
  {
    static List<Dinosaur> NumOfDinos = new List<Dinosaur>();
    static void DinosInPark()
    {
      NumOfDinos.AddRange(new List<Dinosaur> {
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
                Weight = 1200
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

        }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
