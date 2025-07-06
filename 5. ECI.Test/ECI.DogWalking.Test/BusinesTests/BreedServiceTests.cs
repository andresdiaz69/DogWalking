namespace ECI.DogWalking.Test.BusinesTests
{
    using ECI.BusinessContracts.IServices;
    using ECI.BusinessServices.Services;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using Moq;
    using System.Collections.Generic;

    public class BreedServiceTests
    {
        private readonly Mock<IBreedRepository> _repositoryMock;
        private readonly IBreedService _breedService;

        public BreedServiceTests()
        {
            _repositoryMock = new Mock<IBreedRepository>();
            _breedService = new BreedService(_repositoryMock.Object);
        }

        [Fact]
        public void GetAllBreeds_Returns_List()
        {
            // Arranage
            var mockListBreeds = new List<Breed>
            {
                new Breed { Id = 1, isActive = true , Name = "Doberman"},
                new Breed { Id = 2, isActive = true , Name = "Doberman"}
            };

            _repositoryMock.Setup(r => r.GetAllBreeds()).Returns(mockListBreeds);

            // Act
            var result = _breedService.GetAllBreeds();

            // Assert 
            Assert.Equal(2, result.Count);
        }
    }
}
