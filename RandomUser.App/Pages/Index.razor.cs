using Microsoft.AspNetCore.Components;
using RandomUser.App.Services;
using RandomUser.Models;

namespace RandomUser.App.Pages
{
    public partial class Index
    {
        [Inject]
        public IUserService? _userService { get; set; } = null;

        public List<User> Users { get; set; } = new List<User>();

        public string ErrorMessage { get; set; } = string.Empty;

        protected async override Task OnInitializedAsync()
        {  
            if (_userService != null)
            {
                (Users, ErrorMessage) = await _userService.GetRandom5Users();
            }
            else
            {
                ErrorMessage = "Error with User Service";
            }
        }
    }
}
