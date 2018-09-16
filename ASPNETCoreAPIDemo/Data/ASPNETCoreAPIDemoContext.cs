using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreAPIDemo.Model;

namespace ASPNETCoreAPIDemo.Models
{
    public class ASPNETCoreAPIDemoContext : DbContext
    {
        public ASPNETCoreAPIDemoContext (DbContextOptions<ASPNETCoreAPIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCoreAPIDemo.Model.Employee> Employee { get; set; }
    }
}
