using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GogsExhibition.Classes
{
    public abstract class DbNonObj
    {
        public int Id { get; set; }
    }

    public class SpecificalionOfBreed : DbNonObj
    {
        [Required]
        public Breed Breed { get; set; }

        [Required]
        public Specification Specification { get; set; }
    }

    public class ColorOfDog : DbNonObj
    {
        [Required]
        public Dog Dog { get; set; }

        [Required]
        public Color Color { get; set; }
    }

    public class TypesOfShow : DbNonObj
    {
        [Required]
        public Show Show { get; set; }

        [Required]
        public TypeShow Type { get; set; }
    }
}
