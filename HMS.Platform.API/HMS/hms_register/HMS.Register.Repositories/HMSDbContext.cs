using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories
{
    public partial class HMSDbContext:DbContext
    {
        public HMSDbContext()
        {
                
        }
        public HMSDbContext(DbContextOptions<HMSDbContext> options) :base(options)
        {
                
        }

        public virtual DbSet<SignUp> SignUps { get; set; }
    }
}
