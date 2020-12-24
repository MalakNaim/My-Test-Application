using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.Web.DTOs.StatusDTO
{
    public class EditStatusDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="You must Add Status Name")]
        [Display(Name ="Status Name")]
        public string Name { get; set; }
    }
}
