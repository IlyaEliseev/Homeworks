using BlackJackGameCLI.Persons;

namespace BlackJackGameCLI
{
    public class Menu
    {
        public static string CheckUserInputToDrawCard()
        {
            bool isCheck = false;
            string userInput = null;

            do
            {
                Console.Write("Give a card? y/n: ");
                userInput = Console.ReadLine().Trim().ToLower();

                switch (userInput)
                {
                    case "y":
                        isCheck = true;
                        break;
                    case "n":
                        isCheck = true;
                        break;
                    default:
                        Console.WriteLine("Input [y] or [n]");
                        break;
                }
            } while (!isCheck);

            return userInput;
        }

        public static bool CheckUserinputToOneMoreShuffle(bool isShuffleEnd, Person[] players)
        {
            bool isCheck = false;

            do
            {
                Console.Write("Play again? y/n: ");
                string userInput = Console.ReadLine().ToLower().Trim();

                switch (userInput)
                {
                    case "y":
                        isShuffleEnd = false;
                        foreach (var player in players)
                        {
                            player.ClearAll();
                            isCheck = true;
                        }
                        break;
                    case "n":
                        isShuffleEnd = true;
                        isCheck = true;
                        break;
                    default:
                        Console.WriteLine("Input [y] or [n]");
                        break;
                }
            } while (!isCheck);

            return isShuffleEnd;
        }
    }
}
