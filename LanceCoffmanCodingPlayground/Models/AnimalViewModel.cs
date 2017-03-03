using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LanceCoffmanCodingPlayground.DataEntities;

namespace LanceCoffmanCodingPlayground.Models
{
    public class AnimalViewModel
    {
        public IEnumerable<IAnimal> Animals { get; set; }
    }

}