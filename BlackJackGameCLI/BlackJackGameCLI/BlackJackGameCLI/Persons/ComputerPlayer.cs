namespace BlackJackGameCLI.Persons
{
    public class ComputerPlayer : Person
    {
        public ComputerPlayer()
        {
            IsPass = false;
        }

        public override bool IsPass { get; set; }
        private bool isTakeCard = false;
        //public int Total { get; set; }

        private readonly List<Card> _hand = new List<Card>();
        private readonly List<string> _handInformation = new List<string>();

        public override bool SayPass()
        {
            return IsPass = true;
        }
        
        public override bool TakeCard()
        {
            return isTakeCard = true;
        }

        public override void AddCardInHand()
        {
            if (Total <= 18)
            {
                var card = Shoe.GetCard();
                _hand.Add(card);
                GetHandInformation(card);
                CalculateTotal(card);
            }
            else
            {
                SayPass();
            }
        }

        public override List<string> GetHand()
        {
            return _handInformation;
        }

        public override List<string> GetHandInformation(Card card)
        {
            _handInformation.Add(card.Index);

            return _handInformation;
        }
    }
}
