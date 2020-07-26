using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Mission : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Photo { get; set; }
        [Required(ErrorMessage = "iş başlıgı boş bırakılamaz!")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "iş açıklıgı boş bırakılamaz!")]
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        public virtual Status  Status {get;set;}
        public virtual Priority  Priority {get;set;}
    }
}
