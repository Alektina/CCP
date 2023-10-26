using System;
namespace MVCDog.Models
{
	public class Breeder
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DogId { get; set; }
		public int ContactId { get; set; }
		public int KennelId { get; set; }
		public List<Kennel> Kennels { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Contact> Contacts { get; set; }

    }
	
}

