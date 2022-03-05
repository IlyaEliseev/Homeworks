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
                        bool isPlayerWinner = player.GetTotal() <= 21 && player.GetTotal() > cropier.GetTotal();
                        bool isPlayerPointsALot = player.GetTotal() > 21;
                        bool isCroupierWinner = cropier.GetTotal() > player.GetTotal() && cropier.GetTotal() <= 21;

                        if (isPlayerPointsALot)
                        {
                            player.GameStatus = Status.Loser.ToString();
                        }
                        if (isCroupierWinner)
                        {
                            player.GameStatus = Status.Loser.ToString();
                        }
                        if (isPlayerWinner)
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
                    string answer = Menu.CheckUserInputToDrawCard();

                    Person humanPlayer = players
                                .Where(x => x.Name == Roll.HumanPlayer
                                .ToString())
                                .FirstOrDefault();

                    switch (answer)
                    {
                        case "y":
                            if (humanPlayer != null && humanPlayer.GetTotal() <= 21)
                            {
                                humanPlayer.DrawCard();
                            }
                            break;
                        case "n":
                            humanPlayer.SayPass();
                            break;
                        default:
                            break;
                    }

                    foreach (var player in players
                        .Where(x => x.IsPass == false)
                        .Where(x => x.Name != Roll.HumanPlayer
                        .ToString()))
                    {
                        player.DrawCard();
                    }

                    ShowHands();

                    isPass = players.All(x => x.IsPass == true);

                } while (!isPass);
                
                DefineWinner();

                isShuffleEnd = Menu.CheckUserinputToOneMoreShuffle(isShuffleEnd, players);
            }
        }
    }
}
