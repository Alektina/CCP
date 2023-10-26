﻿namespace MVCDog.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Phone_nr { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public string Social_media { get; set; }
        public string Country { get; set; }
        public DateTime? Added_date { get; set; }
        public string About_us { get; set; }
        
    }
}