using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorTest1.Model;

namespace RazorTest1.Data
{
    public class RazorTest1Context : DbContext
    {
        public RazorTest1Context (DbContextOptions<RazorTest1Context> options)
            : base(options)
        {
        }

        public DbSet<RazorTest1.Model.Users> Users { get; set; }
    }
}
