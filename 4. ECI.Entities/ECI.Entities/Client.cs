namespace ECI.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        [Key]
        public required long Id { get; set; }

        [MaxLength(30)]
        public required string Name { get; set; }

        [MaxLength(30)]
        public required string LastName { get; set; }

        [MaxLength(15)]
        public required string PhoneNumber { get; set; }

        public bool isActive { get; set; }

        public ICollection<Dog> Dogs { get; set; }
    }
}
