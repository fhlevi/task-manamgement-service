using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_management_service.Models
{
    public class Users
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}