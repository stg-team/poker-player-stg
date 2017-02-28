using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    public class Player
    {
        public string name { get; set; }
        public int stack { get; set; }
        public Status status { get; set; }
        public int bet { get; set; }
        public Card[] hole_cards { get; set; }
        public string version { get; set; }
        public int id { get; set; }

    }

    public class Card
    {
        public Rank rank;
        public Suit suit;
    }

    public enum Rank
    {
        cA = 1,
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
        cK = 13
    }

    public enum Suit
    {
        clubs,
        spades,
        hearts,
        diamonds
    }
}
