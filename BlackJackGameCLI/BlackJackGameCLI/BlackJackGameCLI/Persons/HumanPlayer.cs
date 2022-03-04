namespace BlackJackGameCLI.Persons
{
    public class HumanPlayer : Person
    {
        public HumanPlayer()
        {
            IsPass = false;
            Name = "Player";
        }

        public override bool IsPass { get; protected set; }

        public override void TakeCard()
        {
            var card = Shoe.GetCard();
            AddCardInHand(card);
            GetHandInformation(card);
            CalculateTotal(card);
        }
    }
}
