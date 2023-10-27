using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVCDog.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Reg_number { get; set; }
        public int? CountryID { get; set; } 


        public DateTime? Birth_date { get; set; }
        
        public string? Sex { get; set; }
        public string? Color{ get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Hairlayers { get; set; }
        public int? TitleId { get; set; }
        public List<Breeder>? Breeders { get; set; }
        public List<Owner>? Owners { get; set; }       
        public int? DogId_Mother { get; set; }       
        public int? DogId_Father { get; set; }      
        public List<Litter>? Litters { get; set; }
        public List<Gallery>? Galleries { get; set; }
        public List<Merit>? Merits { get; set; }
        public List<Kennel>? Kennels { get; set; }
        public List<Title>? Titles { get; set; }
        public List<Country>? Countries{ get; set; }

        public DateTime? Death_date { get; set; }
        public string? Other_info { get; set; }


    }
}



