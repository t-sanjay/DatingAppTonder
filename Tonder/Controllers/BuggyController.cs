using Microsoft.AspNetCore.Mvc;
using Tonder.Data;
using Tonder.Models;

namespace Tonder.Controllers
{
    public class BuggyController : BaseApiController
    {
        private TonderDbContext _context;
        public BuggyController(TonderDbContext context)
        {
            _context = context;
        }

        [HttpGet("Auth")]
        public ActionResult<string> GetSecret()
        {
            return "Secret Text";
        }


        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null) {
                return NotFound();
            }
            return Ok(thing);
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var thing = _context.Users.Find(-1);
            var thingToReturn = thing.ToString();
            return thingToReturn;
        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest();
        }
    }
}
