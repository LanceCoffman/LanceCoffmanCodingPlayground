using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using LanceCoffmanCodingPlayground.Models;
using LanceCoffmanCodingPlayground.DataEntities;


namespace LanceCoffmanCodingPlayground.Controllers
{
    public class SimpleZooController : Controller
    {

        private List<IAnimal> GetAllAnimalsinZoo()
        {
            var animals = new List<IAnimal>();
            animals.Add(new Snake { Name = "Snake", Color = "Black", Habitat = "Grass", AnimalImage = @"c:\Snake.jpg" });
            animals.Add(new Bear { Name = "Bear", Color = "Black", Habitat = "Woods", AnimalImage = @"c:\Bear.jpg" });
            animals.Add(new Whale { Name = "Whale", Color = "Blue", Habitat = "Water", AnimalImage = @"c:\Whale.jpg" });
            animals.Add(new Fish { Name = "Fish", Color = "Blue", Habitat = "Water", AnimalImage = @"c:\Fish.jpg" });
            animals.Add(new Goat { Name = "Goat", Color = "Gray", Habitat = "Mountains", AnimalImage = @"c:\Goat.jpg" });
            animals.Add(new Monkey { Name = "Monkey", Color = "Brown", Habitat = "Trees", AnimalImage = @"c:\Monkey.jpg" });

            return (animals);
        }


        // GET: SimpleZoo
        public ActionResult Index(string color, string habitat)
        {

            var foundAnimals = new List<IAnimal>();

            if (color == null && habitat == null)
            {
                foundAnimals = GetAllAnimalsinZoo().ToList(); //show all for now
            }
            else if (color == null)
            {
                foundAnimals = GetAllAnimalsinZoo().Where(x => x.Habitat.ToLower() == habitat.ToLower()).ToList();
            }
            else
            {
                foundAnimals = GetAllAnimalsinZoo().Where(x => x.Color.ToLower() == color.ToLower() && x.Habitat.ToLower() == habitat.ToLower()).ToList();
            }


            if (foundAnimals == null)
            {
                return HttpNotFound();
            }


            var viewModel = new AnimalViewModel();
            {
                viewModel.Animals = foundAnimals;
            };

            return View(viewModel);
        }
    }
}