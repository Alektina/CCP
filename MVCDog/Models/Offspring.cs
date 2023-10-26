namespace MVCDog.Models
{
    public class Offspring
    {
        public int Id { get; set; }
        
        public int Quantity { get; set; }
        public int MotherId { get; set; }
        public List<Dog> Dogs { get; set; }

    }
}