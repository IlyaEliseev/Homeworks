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

        public void Start()
        {
            Shoe.FillShoe();

            while (!isShuffleEnd)
            {
                Console.Write("Give a card?: ");
                string answer = Console.ReadLine();

                foreach (var player in players)
                {
                    if (answer == "y" && player.IsPass != true)
                    {
                        player.TakeCard();
                    }
                    else
                    {
                        isShuffleEnd = true;
                        Console.WriteLine("End");
                    }
                }

                ShowHands();
            }
        }
    }
}
