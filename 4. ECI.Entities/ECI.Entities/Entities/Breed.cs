namespace ECI.Entities.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Breed
    {
        [Key]
        public required int Id { get; set; }

        [MaxLength(30)]
        public required string Name { get; set; }

        public bool isActive { get; set; }

        public ICollection<Dog> Dogs { get; set; }
    }
}
