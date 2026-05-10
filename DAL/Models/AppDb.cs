using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppDb:DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {
        }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
