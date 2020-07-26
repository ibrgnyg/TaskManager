using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public enum Status
    {
        [Display(Name = "Biti")]
        over = 1,
        [Display(Name = "DevamEdiyorum")]
        KeepGoing = 2,
        [Display(Name = "Az Kaldı")]
        littel = 3,
        [Display(Name = "Ek Süre Talep Ediyorum")]
        addTime = 4,
    }
}
