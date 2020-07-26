using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public enum Priority
    {
        [Display(Name = "Acil")]
        Acil = 1,
        [Display(Name = "Öncelikli")]
        önce = 2,
        [Display(Name = "Normal")]
        normal= 3,
    }
}
