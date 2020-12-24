using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskApp.DbEntity;

namespace TaskApp.Data
{
    public class TaskAppDbContext : IdentityDbContext
    {
        public TaskAppDbContext(DbContextOptions<TaskAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
