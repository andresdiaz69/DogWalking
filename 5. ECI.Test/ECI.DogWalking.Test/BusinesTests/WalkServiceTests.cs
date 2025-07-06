namespace ECI.DogWalking.Test.BusinesTests
{
    using ECI.BusinessContracts.IServices;
    using ECI.BusinessServices.Services;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using Moq;

    public class WalkServiceTests
    {
        private readonly Mock<IWalkRepository> _walkRepoMock;
        private readonly IWalkService _walkService;

        public WalkServiceTests()
        {
            _walkRepoMock = new Mock<IWalkRepository>();
            _walkService = new WalkService(_walkRepoMock.Object);
        }

        [Fact]
        public void DeleteWalk_ExistingId_Returns_True()
        {
            // Arrange
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.GetWalkToUpdate(1)).Returns(walk);
            _walkRepoMock.Setup(r => r.DeleteWalk(walk)).Returns(true);

            // Act
            var result = _walkService.DeleteWalk(1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void DeleteWalk_NotFound_ReturnsFalse()
        {
            // Arranage
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.GetWalk(1)).Returns(walk);
            _walkRepoMock.Setup(r => r.DeleteWalk(walk)).Returns(false);

            // Act
            var result = _walkService.DeleteWalk(99);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void GetAllWalks_Returns_List()
        {
            // Arranage
            var mockWalkList = new List<Walk> {
                new Walk { Id = 1 , Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(0,8,0)},
                new Walk { Id = 2 , Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(0,8,0)}};

            _walkRepoMock.Setup(r => r.GetAllWalks()).Returns(mockWalkList);

            // Act
            var result  = _walkService.GetAllWalks();

            // Assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetWalk_ReturnsWalk()
        {
            // Arrange
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.GetWalk(1)).Returns(walk);

            // Act
            var result = _walkService.GetWalk(1);

            // Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetWalk_NotFound_ReturnsNull()
        {
            // Arrange
            _walkRepoMock.Setup(r => r.GetWalk(99)).Returns((Walk)null);

            // Act
            var result = _walkService.GetWalk(99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void SaveWalk_RepoFails_ReturnTrue()
        {
            // Arrange
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.SaveWalk(walk)).Returns(true);

            // Act
            var result = _walkService.SaveWalk(walk);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void SaveWalk_RepoFails_ReturnsFalse()
        {
            // Arrange
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.SaveWalk(walk)).Returns(false);

            // Act
            var result = _walkService.SaveWalk(walk);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void UpdateWalk_ExistingId_Returns_True()
        {
            // Arrange
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.UpdateWalk(walk)).Returns(true);
            _walkRepoMock.Setup(r => r.GetWalkToUpdate(1)).Returns(walk);

            // Act
            var result = _walkService.UpdateWalk(walk);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UpdateWalk_NotFound_ReturnsFalse()
        {
            // Arranage
            var walk = new Walk { Id = 1, Date = DateTime.Now, DogId = 1, Duration = new TimeSpan(5, 0, 0) };
            _walkRepoMock.Setup(r => r.UpdateWalk(walk)).Returns(false);

            // Act
            var result = _walkService.UpdateWalk(walk);

            // Assert
            Assert.False(result);
        }
    }
}
