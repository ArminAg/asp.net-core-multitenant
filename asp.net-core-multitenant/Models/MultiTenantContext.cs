using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_multitenant.Models
{
    public class MultiTenantContext : DbContext
    {
        public MultiTenantContext(DbContextOptions<MultiTenantContext> options) : base(options)
        {

        }

        public DbSet<Tenant> Tenants { get; set; }
    }
}
