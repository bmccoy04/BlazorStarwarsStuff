using System;
using System.ComponentModel.DataAnnotations;

namespace StarwarsStuff.Ui.Models
{
    public class Person
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "First Name is to long")] 
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Last Name is to long")] 
        public string LastName { get; set; }
        
        [Required]
        public DateTime BirthDate { get; set; }
        
        [Required]
        public Species Species { get; set; }
        
        [Required]
        [Range(1, 100, ErrorMessage = "The range must be between 1 and 100")]
        public int PlanetId { get; set; }
        public bool IsHostile { get; set; }
        
        [Required]
        [Range(1, 10, ErrorMessage = "The range must be between 1 and 10")]
        public int HostileLevel { get; set; }
        
        public Planet Planet { get; set; }
    }

    public enum Species
    {
        Human,
        Gungan,
        Wookie
    }
}