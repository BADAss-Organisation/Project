
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WannaBuy.Models.Account;

namespace WannaBuy.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> _roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            roleManager = _roleManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            var viewModel = new RegisterViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (viewModel == null)
            {
                return View(viewModel);
            }

            var user = new ApplicationUser()
            {
                Email = viewModel.Email,
                FirstName = viewModel.FirstName,
                EmailConfirmed = true,
                LastName = viewModel.LastName,
                UserName = viewModel.FirstName,
            };
            var result = await userManager.CreateAsync(user, viewModel.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            var viewModel = new LoginViewModel()
            {
                ReturnUrl = returnUrl,
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var user = await userManager.FindByEmailAsync(viewModel.Email);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, viewModel.Password, false, false);
                if (result.Succeeded)
                {
                    if (viewModel.ReturnUrl != null)
                    {
                        return Redirect(viewModel.ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> CreateRoles()
        {
            await roleManager.CreateAsync(new IdentityRole("Administrator"));
            await roleManager.CreateAsync(new IdentityRole("User"));

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        [HttpPost]
        public async Task <IActionResult> AddUserstoRoles()
        {
            string email1 = "";
            string email2 = "";

            var user1 =await userManager.FindByEmailAsync(email1);
            var user2 =await userManager.FindByEmailAsync(email2);

            await userManager.AddToRoleAsync(user1,("User"));
            await userManager.AddToRoleAsync(user2, ("Administrator" ));

            return RedirectToAction("Index", "Home");
        }

    }
}
    