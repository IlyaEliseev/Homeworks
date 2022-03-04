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

        bool isShuffleEnd = false;

        private void ShowHands()
        {
            foreach (var player in players)
            {
                player.ShowHand();
            }
        }

        private void CalculatePoints()
        {
            foreach(var player in players)
            {
                player.ShowHand();
            }
        }

        public void Start()
        {
            Shoe.FillShoe();

            while (!isShuffleEnd)
            {
                Console.Write("Give a card?: ");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    Person player = players
                            .Where(x => x.Name == "Player")
                            .FirstOrDefault();
                    if (player != null && player.GetTotal() <= 21)
                    {
                        player.TakeCard();
                    }
                }
                if (answer == "n")
                {
                    Person player = players
                        .Where(x => x.Name == "Player")
                        .FirstOrDefault();
                    player.SayPass();
                }

                foreach (var player in players.Where(x => x.IsPass == false).Where(x => x.Name != "Player"))
                {
                    player.TakeCard();
                }

                ShowHands();
            }
        }
    }
}
