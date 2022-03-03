namespace BlackJackGameCLI
{
    public abstract class Person
    {
        private protected int Total { get; set; }
        private protected string Name { get; set; }
        public abstract bool IsPass { get; set; }

        private readonly List<Card> _hand = new List<Card>();

        private readonly List<string> _handInformation = new List<string>();

        private protected int CalculateTotal(Card card)
        {
            return Total += card.Value;
        }

        private protected bool SayPass()
        {
            return IsPass = true;
        }

        private protected void AddCardInHand(Card card)
        {
            _hand.Add(card);    
        }

        private protected bool GetHandInformation(Card card)
        {
            _handInformation.Add(card.Index);

            return true;
        }

        public abstract void TakeCard();

        public void ShowHand()
        {
            Console.WriteLine($"{Name}: { string.Join(" | ", _handInformation)} [Total: {Total}]");
        }
    }
}
