using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantAuthentication.Authentication
{
    public class ApplicationUser: IdentityUser
    {
        public string TenantId { get; set; } = "DPMTenant";
        public string ClientId { get; set; } = "MyId1";
        public string ClientSecret { get; set; } = "My-First-WebApp-Secret-Key";

    }
}
