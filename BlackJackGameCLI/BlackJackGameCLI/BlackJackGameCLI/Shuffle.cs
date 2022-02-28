using BlackJackGameCLI.Persons;

namespace BlackJackGameCLI
{
    public class Shuffle
    {
        IPerson[] players = new IPerson[]
        {
            new HumanPlayer()
        };

        bool isShuffleEnd = false;

        public void Start()
        {
            while (!isShuffleEnd)
            {
                foreach (var player in players)
                {
                    if (player.TakeCard())
                    {
                        player.AddCardInHand();
                    }
                }
            }
        }

    }
}
