using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace task_management_service.Models
{
    public class Tasks
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueData { get; set; } = DateTime.Now;
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}