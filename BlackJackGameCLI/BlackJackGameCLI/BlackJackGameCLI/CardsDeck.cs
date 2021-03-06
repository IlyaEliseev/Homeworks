namespace BlackJackGameCLI
{
    public struct CardsDeck
    {
        private static Dictionary<string, int> _cards = new()
        {
            { "OneClub", 1 }, { "TwoClub", 2 },
            { "ThreeClub", 3 }, { "FourClub", 4 },
            { "FiveClub", 5 }, { "SixClub", 6 },
            { "SevenClub", 7 }, { "EightClub", 8 },
            { "NineClub", 9 }, { "TenClub", 10 },
            { "JackClub", 10 }, { "QueenClub", 10 },
            { "KingClub", 10 }, { "AceClub", 11 },

            { "OneDiamond", 1 }, { "TwoDiamond", 2 },
            { "ThreeDiamond", 3 }, { "FourDiamond", 4 },
            { "FiveDiamond", 5 }, { "SixDiamond", 6 },
            { "SevenDiamond", 7 }, { "EightDiamond", 8 },
            { "NineDiamond", 9 }, { "TenDiamond", 10 },
            { "JackDiamond", 10 }, { "QueenDiamond", 10 },
            { "KingDiamond", 10 }, { "AceDiamond", 11 },

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
