using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
    public class Utils
    {

        public static Game ConvertToGameState()
        {
            using (var sw = new StreamReader("Playerstatus.json"))
            {
                var str = sw.ReadToEnd();

                Game game = new Game();
                try
                {
                    game.steps = JsonConvert.DeserializeObject<JObject[]>(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return game;
            }

        }

    }
}
