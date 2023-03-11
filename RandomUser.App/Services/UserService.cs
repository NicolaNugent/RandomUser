using RandomUser.Models;
using System.Net.Http.Json;

namespace RandomUser.App.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<(List<User>, string)> GetRandom5Users()
        {
            List<User> users = new List<User>();
            string errorMessage = string.Empty;
            
            // Results param to generate more than 1 user.
            try 
            { 
                var response = await _httpClient.GetFromJsonAsync<Response>("https://randomuser.me/api/?results=5");
                if (response != null && response.results != null)
                {
                    users.AddRange(response.results);
                }
			} 
            catch
            {
                errorMessage = "Unable to Fetch User Data";
            }

			return (users, errorMessage);
        }
    }
}
