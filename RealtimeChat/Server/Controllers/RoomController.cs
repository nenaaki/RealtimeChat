using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealtimeChat.Server.Data;
using RealtimeChat.Shared;

namespace RealtimeChat.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return _context.Rooms
                .Select(each => new Room { Id = each.Id, Name = each.Name })
                .ToArray();
        }
    }
}
