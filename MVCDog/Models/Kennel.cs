namespace MVCDog.Models
{
    public class Kennel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BreederId { get; set; }        
        public int ContactId { get; set; }

        public List<Breeder> Bredeers { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}