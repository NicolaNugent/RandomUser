using Moq;
using RandomUser.App.Services;
using RandomUser.Models;
using System.Reflection;

namespace RandomUser.Tests.Services
{
    [TestClass]
    public class UserServiceTests
    {
        private readonly HttpClient _httpClient;

        public UserServiceTests()
        {
            this._httpClient = new HttpClient();
        }

        [TestMethod]
        public async Task GetRandom5Users_ReturnUsers()
        {
            // Arrange
            var sut = new UserService(_httpClient);

			// Act
			var result = await sut.GetRandom5Users();

			// Assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof((List<Models.User>, string)));
            Assert.AreEqual(result.Item1.Count(), 5);
			Assert.AreEqual(result.Item2, string.Empty);
		}
	}
}