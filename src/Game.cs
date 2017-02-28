using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
    public class Game : JObject
    {
        public JObject[] steps { get; set;}
    }
}
