using BlackJackGameCLI.Persons;

namespace BlackJackGameCLI
{
    public class Shuffle
    {
        Person[] players = new Person[]
        {
            new HumanPlayer(),
            new ComputerPlayer(),
            new ComputerPlayer(),
            new Croupier()
        };

        private void ShowHands()
        {
            foreach (var player in players)
            {
                player.ShowHand();
            }
        }

        private void DefineWinner()
        {
            if (players.All(x => x.IsPass == true))
            {
                Person cropier = players
                .FirstOrDefault(x => x.Name == Roll.Croupier.ToString());

                if (cropier != null)
                {
                    foreach (var player in players.Where(x => x.Name != Roll.Croupier.ToString()))
                    {
                        if (player.GetTotal() > 21)
                        {
                            player.GameStatus = Status.Loser.ToString();
                        }
                        if (cropier.GetTotal() > player.GetTotal() && cropier.GetTotal() <= 21)
                        {
                            player.GameStatus = Status.Loser.ToString();
                        }
                        if (player.GetTotal() <= 21)
                        {
                            player.GameStatus = Status.Winner.ToString();
                        }

                        Console.WriteLine($"{player.Name}: {player.GameStatus}");
                    }
                }
            }
        }

        bool isShuffleEnd = false;
        bool isPass = false;

        public void Start()
        {
            Shoe.FillShoe();

            while (!isShuffleEnd)
            {
                do
                {
                    Console.Write("Give a card? y/n: ");
                    string answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "y")
                    {
                        Person humanPlayer = players
                                .Where(x => x.Name == Roll.Player.ToString())
                                .FirstOrDefault();

                        if (humanPlayer != null && humanPlayer.GetTotal() <= 21)
                        {
                            humanPlayer.TakeCard();
                        }
                    }
                    if (answer == "n")
                    {
                        Person humanPlayer = players
                            .Where(x => x.Name == Roll.Player.ToString())
                            .FirstOrDefault();

                        humanPlayer.SayPass();
                    }

                    foreach (var player in players
                        .Where(x => x.IsPass == false)
                        .Where(x => x.Name != Roll.Player.ToString()))
                    {
                        player.TakeCard();
                    }

                    ShowHands();

                    isPass = players.All(x => x.IsPass == true);

                } while (!isPass);
                
                DefineWinner();
                
                Console.Write("Play again? y/n: ");
                string userInput = Console.ReadLine().ToLower().Trim();

                if (userInput == "y")
                {
                    isShuffleEnd = false;
                    foreach (var player in players)
                    {
                        player.ClearAll();
                    }
                }
                else if (userInput == "n")
                {
                    isShuffleEnd = true;
                }
            }
        }
    }
}
