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

        private void CalculatePoints()
        {
            
            if (players.All(x => x.IsPass == true))
            {
                Person cropier = players
                .FirstOrDefault(x => x.Name == Roll.Croupier.ToString());
                foreach (var player in players)
                {
                    Console.WriteLine("1");
                }
            }
        }

        bool isShuffleEnd = false;

        public void Start()
        {
            Shoe.FillShoe();

            while (!isShuffleEnd)
            {
                Console.Write("Give a card?: ");
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
                CalculatePoints();
            }
        }
    }
}
