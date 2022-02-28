using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGameCLI
{
    public struct CardsDeck
    {
        private Dictionary<string, int> _cards = new()
        {
            { "One Club", 1 },
            { "Two Club", 2 },
            { "Three Club", 3 },
            { "Four Club", 4 },
            { "Five Club", 5 },
            { "Six Club", 6 },
            { "Seven Club", 7 },
            { "Eight Club", 8 },
            { "Nine Club", 9 },
            { "Ten Club", 10 },
            { "Jack Club", 10 },
            { "Queen Club", 10 },
            { "King Club", 10 },
            { "Ace Club", 11 },

            { "OneDiamond", 1 },
            { "TwoDiamond", 2 },
            { "ThreeDiamond", 3 },
            { "FourDiamond", 4 },
            { "FiveDiamond", 5 },
            { "SixDiamond", 6 },
            { "SevenDiamond", 7 },
            { "EightDiamond", 8 },
            { "NineDiamond", 9 },
            { "TenDiamond", 10 },
            { "JackDiamond", 10 },
            { "QueenDiamond", 2 },
            { "AceDiamond", 2 },

            { "OneHeart", 2 },
            { "TwoHeart", 2 },
            { "ThreeHeart", 2 },
            { "FourHeart", 2 },
            { "FiveHeart", 2 },
            { "SixHeart", 2 },
            { "SevenHeart", 2 },
            { "EightHeart", 2 },
            { "NineHeart", 2 },
            { "TenHeart", 2 },
            { "JackHeart", 2 },
            { "QueenHeart", 2 },
            { "KingHeart", 2 },
            { "AceHeart", 2 },

            { "OneSpade", 2 },
            { "TwoSpade", 2 },
            { "ThreeSpade", 2 },
            { "FourSpade", 2 },
            { "FiveSpade", 2 },
            { "SixSpade", 2 },
            { "SevenSpade", 2 },
            { "EightSpade", 2 },
            { "NineSpade", 2 },
            { "TenHSpade", 2 },
            { "JackSpade", 2 },
            { "QueenSpade", 2 },
            { "KingSpade", 2 },
            { "AceSpade", 2 }
            


            //OneSpade = 1,
            //TwoSpade = 2,
            //ThreeSpade = 3,
            //FourSpade = 4,
            //FiveSpade = 5,
            //SixSpade = 6,
            //SevenSpade = 7,
            //EightSpade = 8,
            //NineSpade = 9,
            //TenHSpade = 10,
            //JackSpade = 10,
            //QueenSpade = 10,
            //KingSpade = 10,
            //AceSpade = 11
        };
    }
}
