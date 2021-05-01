using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_6.Models
{
    public class Login
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Description { get; set; }
        public DateTime Date { get; set; }
        public IdentityUser User { get; set; }
        
    }
}
