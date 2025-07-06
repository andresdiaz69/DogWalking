namespace ECI.Entities.Entities
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

        public required int PhoneNumber { get; set; }

        public bool isActive { get; set; }

        public ICollection<Dog> Dogs { get; set; }
    }
}
