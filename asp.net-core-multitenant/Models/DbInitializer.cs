using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_multitenant.Models
{
    public static class DbInitializer
    {
        public static void Initialize(MultiTenantContext context)
        {
            context.Database.EnsureCreated();

            if (context.Tenants.Any())
            {
                return;
            }

            var tenants = new Tenant[]
            {
                new Tenant
                {
                     Name = "Audi",
                     DomainName = "www.audi.com",
                     Id = 1,
                     Default = true
                },
                new Tenant
                {
                     Name = "BMW",
                     DomainName = "www.bmw.com",
                     Id = 2,
                     Default = false
                },
                new Tenant
                {
                     Name = "Porsche",
                     DomainName = "www.porsche.com",
                     Id = 3,
                     Default = false
                }
            };
            context.Tenants.AddRange(tenants);
            context.SaveChanges();
        }
    }
}
