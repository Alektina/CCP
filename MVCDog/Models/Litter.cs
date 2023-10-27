using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDog.Models
{
    public class Litter
    {
        public int Id { get; set; }
        public int Quantity { get; set; }                
        public DateTime Birth_date { get; set; }
        public Dog Dog { get; set; }        
        public int MotherId { get; set; }
        public int FatherId { get; set; }

    }
}