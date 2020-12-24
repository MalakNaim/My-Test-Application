using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Web.DTOs.TaskDTO
{
    public class CreateTaskDTO
    {
        [Required(ErrorMessage = "You must Add Task Title")]
        [Display(Name = "Task Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must Add Task Description")]
        [Display(Name = "Task Title")]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required(ErrorMessage = "You must Add Assigned To User")]
        [Display(Name = "Assigned To User")]
        public string AssignedToUser { get; set; }
    }
}
