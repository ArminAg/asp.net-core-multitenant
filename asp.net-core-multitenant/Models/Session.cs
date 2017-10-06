using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_multitenant.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string Title { get; set; }
        public string DescriptionShort { get; set; }
        public string Description { get; set; }
        public int PictureId { get; set; }

        public Tenant Tenant { get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}
