namespace MVCDog.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Fil_name { get; set; }
        public string Description { get; set; }
        public int DogId { get; set; }
        public List<Dog> Dogs { get; set; }

    }
}