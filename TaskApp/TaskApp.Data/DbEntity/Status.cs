using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApp.Data.DbEntity;

namespace TaskApp.DbEntity
{
    public class Status:BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
