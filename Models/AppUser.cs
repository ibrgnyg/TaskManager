using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class AppUser:IdentityUser
    {
        public virtual  ICollection<Mission> Missions { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
