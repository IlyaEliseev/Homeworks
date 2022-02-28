namespace BlackJackGameCLI
{
    public struct CardsDeck
    {
        private static Dictionary<string, int> _cards = new()
        {
            { "One Club", 1 }, { "Two Club", 2 },
            { "Three Club", 3 }, { "Four Club", 4 },
            { "Five Club", 5 }, { "Six Club", 6 },
            { "Seven Club", 7 }, { "Eight Club", 8 },
            { "Nine Club", 9 }, { "Ten Club", 10 },
            { "Jack Club", 10 }, { "Queen Club", 10 },
            { "King Club", 10 }, { "Ace Club", 11 },

            { "One Diamond", 1 }, { "Two Diamond", 2 },
            { "Three Diamond", 3 }, { "Four Diamond", 4 },
            { "Five Diamond", 5 }, { "Six Diamond", 6 },
            { "Seven Diamond", 7 }, { "Eight Diamond", 8 },
            { "Nine Diamond", 9 }, { "Ten Diamond", 10 },
            { "Jack Diamond", 10 }, { "Queen Diamond", 10 },
            { "King Diamond", 10 }, { "Ace Diamond", 11 },

            { "OneHeart", 1 }, { "TwoHeart", 2 },
            { "ThreeHeart", 3 }, { "FourHeart", 4 },
            { "FiveHeart", 5 }, { "SixHeart", 5 },
            { "SevenHeart", 7 }, { "EightHeart", 8 },
            { "NineHeart", 9 }, { "TenHeart", 10 },
            { "JackHeart", 10 }, { "QueenHeart", 10 },
            { "KingHeart", 10 }, { "AceHeart", 11 },

            { "OneSpade", 1 }, { "TwoSpade", 2 },
            { "ThreeSpade", 3 }, { "FourSpade", 4 },
            { "FiveSpade", 5 }, { "SixSpade", 6 },
            { "SevenSpade", 7 }, { "EightSpade", 8 },
            { "NineSpade", 9 }, { "TenHSpade", 10 },
            { "JackSpade", 10 }, { "QueenSpade", 10 },
            { "KingSpade", 10 }, { "AceSpade", 11 }
        };

        public static Dictionary<string, int> GetCardsDeck()
        {
            return _cards;
        }
    }
}
