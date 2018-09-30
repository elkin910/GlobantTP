using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobantTP.RestService.Models
{
    public class President
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Birthplace { get; set; }
        public string DeathDay  { get; set; }
        public string DeathPlace { get; set; }
    }
}