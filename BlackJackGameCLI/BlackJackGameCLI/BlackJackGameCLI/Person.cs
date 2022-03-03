namespace BlackJackGameCLI
{
    public abstract class Person
    {
        public  int Total { get; set; }
        public string Name { get; set; }

        private readonly List<Card> _hand = new List<Card>();

        private readonly List<string> _handInformation = new List<string>();

        public int CalculateTotal(Card card)
        {
            return Total += card.Value;
        }

        public abstract bool IsPass { get; set; }

        public bool SayPass()
        {
            return IsPass = true;
        }

        public void AddCardInHand(Card card)
        {
            _hand.Add(card);    
        }

        //public  List<string> GetHand()
        //{
        //    return _handInformation;
        //}

        public  bool GetHandInformation(Card card)
        {
            _handInformation.Add(card.Index);

            return true;
        }

        public int GetTotal()
        {
            return Total;
        }

        public abstract void TakeCart();

        public void ShowHand()
        {
            Console.WriteLine($"{Name}: { string.Join(" | ", _handInformation)} [Total: {Total}]");
        }
    }
}
