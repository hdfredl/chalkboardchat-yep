using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChalkboardChat.UI.Pages.Member
{
    public class MessagesModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public string? Username { get; set; }

        // Denna property kanske inte beh�ver skickas med ?
        public string? Password { get; set; }

        public MessagesModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public void OnGet()
        {
            _signInManager.UserManager.GetUserAsync(HttpContext.User);

            Username = User.Identity.Name;
        }
    }
}
