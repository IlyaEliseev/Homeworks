namespace BlackJackGameCLI.Persons
{
    public abstract class Person
    {
        private protected int _total;
        public string GameStatus { get; set; }
        public string Name { get; private protected set; }
        public abstract bool IsPass { get; protected set; }

        private readonly List<Card> _hand = new List<Card>();

        private readonly List<string> _handInformation = new List<string>();

        private protected int CalculateTotal(Card card)
        {
            return _total += card.Value;
        }

        public bool SayPass()
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
            Console.WriteLine($"{Name} : { string.Join(" | ", _handInformation)} [Total: {_total}]");
        }

        public int GetTotal()
        {
            return _total;
        }

        public void ClearAll()
        {
            _hand.Clear();
            _handInformation.Clear();
            _total = 0;
            IsPass = false;
            GameStatus = null;
        }
    }
}
