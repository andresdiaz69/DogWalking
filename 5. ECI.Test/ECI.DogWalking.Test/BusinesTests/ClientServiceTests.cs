namespace ECI.DogWalking.Test.BusinesTests
{
    using ECI.BusinessContracts.IServices;
    using ECI.BusinessServices.Services;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClientServiceTests
    {
        private readonly Mock<IClientRepository> _clientRepositoryMock;
        private readonly IClientService _clientService;

        public ClientServiceTests()
        {
            _clientRepositoryMock = new Mock<IClientRepository>();
            _clientService = new ClientService(_clientRepositoryMock.Object);
        }

        [Fact]
        public void GetAllCLients_Returns_List()
        {
            // Arrange
            var mockClientList = new List<Client>
            {
                new Client { Id =1, Name = "Andres", LastName = "Diaz", PhoneNumber =15788048 },
                new Client { Id =2, Name = "Andres", LastName = "Diaz", PhoneNumber =315788048 }
            };

            _clientRepositoryMock.Setup(r => r.GetAllCLients(true)).Returns(mockClientList);

            // Act
            var result = _clientService.GetAllCLients(true);

            // Assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetClient_ReturnsClient()
        {
            // Arrange
            var mockClient = new Client { Id = 1, Name = "Andres", LastName = "Diaz", PhoneNumber = 15788048 };

            _clientRepositoryMock.Setup(r => r.GetClient(1)).Returns(mockClient);

            // Act
            var result = _clientService.GetClient(1);

            // Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetClient_ReturnsNull()
        {
            // Arrange
            _clientRepositoryMock.Setup(r => r.GetClient(99)).Returns((Client)null);

            // Act
            var result = _clientService.GetClient(99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void SaveClient_ReturnsTrue()
        {
            // Arrange
            var mockClient = new Client { Id = 1, Name = "Andres", LastName = "Diaz", PhoneNumber = 15788048 };
            _clientRepositoryMock.Setup(r => r.SaveClient(mockClient)).Returns(true);

            // Act
            var result = _clientService.SaveClient(mockClient);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void SaveClient_ReturnsFalse()
        {
            // Arrange
            var mockClient = new Client { Id = 1, Name = "Andres", LastName = "Diaz", PhoneNumber = 15788048 };
            _clientRepositoryMock.Setup(r => r.SaveClient(mockClient)).Returns(false);

            // Act
            var result = _clientService.SaveClient(mockClient);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void UpdateClient_ExistingId_ReturnsTrue()
        {
            // Arrange
            var mockClient = new Client { Id = 1, Name = "Andres", LastName = "Diaz", PhoneNumber = 15788048 };
            _clientRepositoryMock.Setup(r => r.UpdateClient(mockClient)).Returns(true);
            _clientRepositoryMock.Setup(r => r.GetClient(1)).Returns(mockClient);

            // Act
            var result = _clientService.UpdateClient(mockClient);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UpdateClient_NotFound_ReturnsFalse()
        {
            // Arrange
            var mockClient = new Client { Id = 1, Name = "Andres", LastName = "Diaz", PhoneNumber = 15788048 };
            _clientRepositoryMock.Setup(r => r.UpdateClient(mockClient)).Returns(false);
            _clientRepositoryMock.Setup(r => r.GetClient(1)).Returns(mockClient);

            // Act
            var result = _clientService.UpdateClient(mockClient);

            // Assert
            Assert.False(result);
        }
    }
}
