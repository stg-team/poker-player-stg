using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
    public class Player : JObject
    {
        public string name { get; set; }
        public int stack { get; set; }
        public Status status { get; set; }
        public int bet { get; set; }
        public Card[] hole_cards { get; set; }
        public string version { get; set; }
        public int id { get; set; }

    }

    public class Card : JObject
    {
        public Rank rank;
        public Suit suit;
    }

    public enum Rank
    {

        c2 = 2,
        c3 = 3,
        c4 = 4,
        c5 = 5,
        c6 = 6,
        c7 = 7,
        c8 = 8,
        c9 = 9,
        c10 = 10,
        cJ = 11,
        cQ = 12,
        cK = 13,
        cA = 14,
    }

    public enum Suit
    {
        clubs,
        spades,
        hearts,
        diamonds
    }
}
