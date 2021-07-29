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

        //public DbObjs(string _Name)
        //{
        //    Name = _Name;
        //}
    }

    public abstract class DbObjActive : DbObjs
    {
        [Required]
        public DateTime DateBirth { get; set; }

        [Required]
        public Sex Sex { get; set; }
    }

    public class Dog : DbObjActive, IDbMapped
    {
        [Required]
        public Breed Breed { get; set; }

        [Required]
        public Owner Owner { get; set; }

        public float Weight { get; set; }

        public float Growth { get; set; }

        public float Leght { get; set; }
    }

    public class Owner : DbObjActive, IDbMapped
    {
        public Country Country { get; set; }
    }

    public class Breed : DbObjs, IDbMapped
    {
        public float MaxWeight { get; set; }

        public float MaxGrowth { get; set; }
    }

    public class Country : DbObjs, IDbMapped
    {
        public byte[] Flag { get; set; }
    }

    public class Specification : DbObjs, IDbMapped
    {
        
    }

    public class Color : DbObjs, IDbMapped
    {

    }

    public class Show : DbObjs, IDbMapped
    {
        [Required]
        public DateTime DateOf { get; set; }

        public DateTime DateTo { get; set; }

        [Required]
        public Country Country { get; set; }
    }

    public class TypeShow : DbObjs, IDbMapped
    {

    }

    public class Sex : DbObjs, IDbMapped
    {

    }

    public class User : DbObjActive, IDbMapped
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public Role Role { get; set; }
    }

    public class Role : DbObjs, IDbMapped
    {

    }
}
