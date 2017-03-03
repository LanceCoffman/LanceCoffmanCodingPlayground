using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LanceCoffmanCodingPlayground.DataEntities
{
    public interface IAnimal
    {
        [Display(Name = "Name")]
        string Name { get; set; }
        [Display(Name = "Color")]
        string Color { get; set; }
        [Display(Name = "Habitat")]
        string Habitat { get; set; }
        [Display(Name = "Image")]
        string AnimalImage { get; set; }
        [Display(Name = "Movement")]
        string Movement();
    }
}
