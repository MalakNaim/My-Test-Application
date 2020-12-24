using System;
using System.Collections.Generic;
using System.Text;

namespace TaskApp.Data.DbEntity
{
   public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDelete { get; set; }
    }
}
