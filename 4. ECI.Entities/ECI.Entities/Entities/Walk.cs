namespace ECI.Entities.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Walk
    {
        [Key]
        public required long Id { get; set; }

        public required TimeSpan Duration { get; set; }

        public DateTime Date { get; set; }

        public required long DogId { get; set; }

        public Dog Dog { get; set; }
    }
}
