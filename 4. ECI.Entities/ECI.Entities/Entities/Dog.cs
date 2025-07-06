namespace ECI.Entities.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Dog
    {
        [Key]
        public required long Id { get; set; }

        [MaxLength(30)]
        public required string Name { get; set; }

        public required short Age { get; set; } = 0;

        public bool isActive { get; set; }

        public long ClientId { get; set; }
        
        public Client Client { get; set; }

        public int BreedId { get; set; }

        public Breed Breed { get; set; } = null!;

        public ICollection<Walk> Walks { get; set; }
    }
}
