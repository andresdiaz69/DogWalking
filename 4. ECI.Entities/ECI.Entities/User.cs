namespace ECI.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public required long Id { get; set; }

        [MaxLength(30)]
        public required string Name { get; set; }

        [MaxLength(30)]
        public required string LastName { get; set; }

        [MaxLength(50)]
        public required string Email { get; set; }
        
        [MaxLength(100)]
        public required string Password { get; set; }

        public bool isActive { get; set; }
    }
}
