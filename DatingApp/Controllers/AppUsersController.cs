using DatingApp.Data;
using DatingApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public AppUsersController(ApplicationContext context)
        {
                 _context= context;
        }
        [HttpGet]   
        public async Task< ActionResult <IEnumerable<AppUser>>> GetUser()
        {
            var user= await _context.AUsers.ToListAsync();
            return Ok(user);
        }
        [HttpGet("{Id}")]
        public async Task< ActionResult <AppUser>> GetUser(int Id)
        {
            var user = await _context.AUsers.FindAsync(Id);
            return Ok(user);    
        }

    }
}
