using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp.net_core_multitenant.Models;

namespace asp.net_core_multitenant.Controllers
{
    public class TenantController : Controller
    {
        public IActionResult Index()
        {
            var tenants = new List<Tenant>
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
                     Id = 1,
                     Default = false
                },
                new Tenant
                {
                     Name = "Porsche",
                     DomainName = "www.porsche.com",
                     Id = 1,
                     Default = false
                }
            };
            return View(tenants);
        }
    }
}
