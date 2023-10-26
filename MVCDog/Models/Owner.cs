namespace MVCDog.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public List<Dog> Dogs { get; set; }
        public int ContactId { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}