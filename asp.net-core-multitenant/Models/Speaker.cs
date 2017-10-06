using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_multitenant.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string WebSite { get; set; }
        public string Bio { get; set; }
        public bool AllowHtml { get; set; }
        public int PictureId { get; set; }

        public List<Session> Sessions { get; set; }
    }
}
