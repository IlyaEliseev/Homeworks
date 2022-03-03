﻿namespace BlackJackGameCLI.Persons
{
    public class HumanPlayer : Person
    {
        public HumanPlayer()
        {
            IsPass = false;
        }

        public override bool IsPass { get; set; }
        private bool isTakeCard = false;
        

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
            var card = Shoe.GetCard();
            _hand.Add(card);
            GetHandInformation(card);
            CalculateTotal(card);
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
