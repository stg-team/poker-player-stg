using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{




    public class Tournament
    {
        public string id {get; set;}
        public string tournament_id { get; set; }
        public DateTime started { get; set; }
        public Status status { get; set; }
        public Team[] teams { get; set; }
        public string salted_response_token { get; set; }
        public DateTime finished { get; set; }
    }
}
