using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PractApp.Clients;

namespace PractApp.Models
{
    public class PractAppContext : DbContext
    {
        public PractAppContext (DbContextOptions<PractAppContext> options)
            : base(options)
        {
        }

        public DbSet<PractApp.Clients.Client> Client { get; set; }
    }
}
