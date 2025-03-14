using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportMonksSDK.API.Football.Entities
{
    public class Bookmaker
    {
        public int id { get; set; }
        public int? legacy_id { get; set; }
        public string? name { get; set; }
    }
}
