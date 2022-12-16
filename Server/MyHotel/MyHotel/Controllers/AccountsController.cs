using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyHotel.Data;
using MyHotel.Models;
using MyHotel.Models.RequestModels;

namespace MyHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
                private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;



        public AccountsController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.db = context;
            this.userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }




        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginRequestModel model)
        //{
        //    if (!ModelState.IsValid)
        //        return View(model);

        //    var user = await userManager.FindByEmailAsync(model.Email);
        //    if (user == null)
        //    {
        //        ModelState.AddModelError("", "Invalid details");
        //        return View(model);
        //    }

        //    var res = await S.PasswordSignInAsync(user, model.Password, true, true);

        //    if (res.Succeeded)

        //    return View(model);
        //}



        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            var user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = new Guid().ToString().Replace("-",""),
                PhoneNumber = model.PhoneNumber,
                Aadhar= model.Aadhar,
                Age = model.Age,
            };
            var res = await userManager.CreateAsync(user, model.Password);
            if (!res.Succeeded)
               return BadRequest(res);

            await db.SaveChangesAsync();
            return Ok(user);
        }

        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //}
    }
}

