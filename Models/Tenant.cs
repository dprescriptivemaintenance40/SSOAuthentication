using PlantAuthentication.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantAuthentication.Models
{
    public class Tenant
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string TenantId { get; set; }
        public Tenant()
        {
            this.TenantId = "DPMTenant";
        }
    }
}
