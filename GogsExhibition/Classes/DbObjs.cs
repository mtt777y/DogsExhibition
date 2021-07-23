using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GogsExhibition.Classes
{
    public abstract class DbObjs
    {
        public int Id { get; set; }

        [MaxLength(200), Required]
        public string Name {get; set; }
    }

    public abstract class DbObjActive : DbObjs
    {
        [Required]
        public DateTime DateBirth { get; set; }

        [Required]
        public Sex Sex { get; set; }
    }

    public class Dog : DbObjActive
    {
        [Required]
        public Breed Breed { get; set; }

        [Required]
        public Owner Owner { get; set; }

        public float Weight { get; set; }

        public float Growth { get; set; }

        public float Leght { get; set; }
    }

    public class Owner : DbObjActive
    {
        public Country Country { get; set; }
    }

    public class Breed : DbObjs
    {
        public float MaxWeight { get; set; }

        public float MaxGrowth { get; set; }
    }

    public class Country : DbObjs
    {
        public byte[] Flag { get; set; }
    }

    public class Specification : DbObjs
    {
        
    }

    public class Color : DbObjs
    {

    }

    public class Show : DbObjs
    {
        [Required]
        public DateTime DateOf { get; set; }

        public DateTime DateTo { get; set; }

        [Required]
        public Country Country { get; set; }
    }

    public class TypeShow : DbObjs
    {

    }

    public class Sex : DbObjs
    {

    }

    public class User : DbObjActive
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
