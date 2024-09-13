using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using task_management_service.Data;

namespace task_management_service.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController: ControllerBase 
    {
        private readonly ApplicationDBContext _context;
        public UsersController(ApplicationDBContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var users = _context.Users.ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] string id) 
        {
            var users = _context.Users.Find(id);

            if (users == null) return NotFound();
            return Ok(users);
        }
    }
}