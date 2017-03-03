using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanceCoffmanCodingPlayground.DataEntities
{
    public class Snake:IAnimal
    {
        public string AnimalImage { get; set; }
        public string Color { get; set; }
        public string Habitat { get; set; }
        public string Name { get; set; }

        public string Movement()
        {
            return "Slither";
        }
    }
}