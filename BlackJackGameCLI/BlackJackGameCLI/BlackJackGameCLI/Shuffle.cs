using BlackJackGameCLI.Persons;
using System.Text;

namespace BlackJackGameCLI
{
    public class Shuffle
    {
        Person[] players = new Person[]
        {
            new HumanPlayer(),
            new ComputerPlayer(),
            new ComputerPlayer(),
            new ComputerPlayer()
        };

        bool isShuffleEnd = false;

        private void ShowHands()
        {
            foreach (var player in players)
            {
                Console.WriteLine(string.Join(" ", player.GetHand()));
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
                        player.AddCardInHand();
                         
                    }
                    //player.GetHandInformation();
                    //player.GetHand().ForEach(hand =>
                    //{
                    //    Console.Write($"{hand.Index} {hand.Value}");
                    //});
                }
                ShowHands();
            }
        }
    }
}
