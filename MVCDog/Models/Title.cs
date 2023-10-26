namespace MVCDog.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string Title_Name { get; set; }
        public int DogId { get; set; }
        public Dog Dog { get; set; }

    }
}