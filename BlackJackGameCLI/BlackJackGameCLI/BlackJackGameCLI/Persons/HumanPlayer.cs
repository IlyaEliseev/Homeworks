namespace BlackJackGameCLI.Persons
{
    internal class HumanPlayer : IPerson
    {
        private bool isPass = false;
        private bool isTakeCard = false;

        private readonly List<Card> _hand = new List<Card>();

        public bool SayPass()
        {
            return isPass = true;
        }

        public bool TakeCard()
        {
            return isTakeCard = true;
        }

        public  void AddCardInHand()
        {
            if (TakeCard() && !SayPass())
            {
                _hand.Add(Shoe.GetCard());
            }
        }
    }
}
