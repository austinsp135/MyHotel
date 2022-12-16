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



        public AccountsController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            this.db = context;
            this.userManager = userManager;
        }



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
                Aadhar= model.Aadhar
                
            };
            var res = await userManager.CreateAsync(user);
            if (!res.Succeeded)
               return BadRequest(res);

            await db.SaveChangesAsync();
            return Ok(user);
            return Ok(model);
        }
    }
}

