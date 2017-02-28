using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    public class Team
    {
        public string name { get; set; }
        public string url { get; set; }
        public string instance_id { get; set; }
        public string commit_id_at_start { get; set; }
        public int ranking { get; set; }
        public string version { get; set; }
        public int gained { get; set; }
        public string commit_id { get; set; }
        public int points { get; set; }
        public double relative_points { get; set; }
        public bool deployed { get; set; }
    }
}
