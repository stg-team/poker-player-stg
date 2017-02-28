using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
    public class GameStep :JObject
    {
        public string type { get; set; }
        public string message { get; set; }
        public GameState game { get; set; }
    }
}
