using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Autentication_Module_RP.Models;

namespace Autentication_Module_RP.Data
{
    public class RDPCUserContext : DbContext
    {
        public RDPCUserContext (DbContextOptions<RDPCUserContext> options)
            : base(options)
        {
        }

        public DbSet<Autentication_Module_RP.Models.User> User { get; set; }
    }
}
