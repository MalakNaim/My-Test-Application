using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp.DbEntity
{
    public class Tasks
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime CompletedOn { get; set; }
        public DateTime RejectedOn { get; set; }
        public string RejectedReason { get; set; }
        public string AssignedToUser { get; set; }
        public int StatusID { get; set; }
        public Status Status { get; set; }
    }
}
