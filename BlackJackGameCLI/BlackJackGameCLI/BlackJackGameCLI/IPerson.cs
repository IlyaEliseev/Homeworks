namespace BlackJackGameCLI
{
    public abstract class Person
    {
        public int Total { get; set; }
        //public bool IsPass = false;
        public int CalculateTotal(Card card)
        {
            return Total += card.Value;
        }
        public abstract bool IsPass { get; set; }
        public abstract bool TakeCard();
        public abstract bool SayPass();
        public abstract void AddCardInHand();
        public abstract List<string> GetHand();
        public abstract List<string> GetHandInformation(Card card);
    }
}
