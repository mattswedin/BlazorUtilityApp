using Microsoft.AspNetCore.Mvc; // imports namespaces to create an API controller (GET, POST, etc.), ControllerBase class
using Microsoft.EntityFrameworkCore; // allows querying and updating of the database in this context, DataContext class
using WebApi.Models;
using System.Linq; //Language Integrated Query - set of methods and syntax in C# to query and manipulate data in a more readable and concise way

namespace WebApi.Controllers
{
    [Route("api/user")] //endpoint //any HTTP request to api/user will be handled by this controller
    [ApiController] //auto model validation
    public class UserController : ControllerBase //inheritts from ControllerBase >> built-in class from AspNetCore - base for API controllers >> methods for HTTP res
    {
        private readonly DataContext _context;

        public UserController(DataContext context) //injects instance of DataContext into the controller
        {
            _context = context;
        }

        // GET: api/user
        [HttpGet] //automatically maps incoming GET requests to this method below
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            //^^^Task - operation that is in progress and hasnt completed yet, ActionResult - result of Action (OK or 404), IEnumerable<User> - reps collection of itmes that can be looped through

            //fetches all users from database
            List<User> users = await _context.Users.ToListAsync();
            return Ok(users); // returns users at the api/user endpoint, ControllerBase class, indicates success
        }

        // GET: api/user{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User user = await _context.Users.FindAsync(id);

            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST: api/user
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            //Add new user to the database
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user); //created response, creates the URL for the newly created resource - using the id to fetch the specific user later.
        }

    }
}