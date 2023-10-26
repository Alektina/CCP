namespace MVCDog.Models
{
    public class Merit
    {
        public int Id { get; set; }
        public string Merit_name { get; set; }
        public string? Merit_date { get; set; }
        public string? Best_in_show { get; set; }
        public string? National_BISS { get; set; }
        public string? Group { get; set; }
        public string? Winner { get; set; }
        public string? BIS { get; set; }
        public string? Top { get; set; }
        public string? Other { get; set; }
        public int DogId { get; set; }

        public required Dog Dog { get; set; }
    }
}