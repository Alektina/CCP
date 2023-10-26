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
        
        public string Birth_date { get; set; }
        public string? Death_date { get; set; }
        public char Sex_char{ get; set; }
        public string Color{ get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Powderpuff { get; set; }
        public string? TitleId { get; set; }
        public List<Breeder>? Breeders { get; set; }
        public List<Owner>? Owners { get; set; }       
        public int? DogId_Mother { get; set; }       
        public int? DogId_Father { get; set; }      
        public List<Litter>? Litters { get; set; }
        public List<Offspring>? Offsprings { get; set; }
        public List<Gallery>? Galleries { get; set; }
        public List<Merit>? Merits { get; set; }
        public List<Kennel>? Kennels { get; set; }
        public List<Title>? Titles { get; set; }
        public string? Other_info { get; set; }


    }
}



/*


public class Match 
{
   public int? HomeTeamId { get; set; }
public int? GuestTeamId { get; set; }

public float HomePoints { get; set; }
public float GuestPoints { get; set; }
public DateTime Date { get; set; }

public Team HomeTeam { get; set; }
public Team GuestTeam { get; set; }
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Match>()
                .HasRequired(m => m.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

    modelBuilder.Entity<Match>()
                .HasRequired(m => m.GuestTeam)
                .WithMany(t => t.AwayMatches)
                .HasForeignKey(m => m.GuestTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);
}

*/
