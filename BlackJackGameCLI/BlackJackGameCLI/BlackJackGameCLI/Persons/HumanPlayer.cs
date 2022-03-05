namespace BlackJackGameCLI.Persons
{
    public class HumanPlayer : Person
    {
        public HumanPlayer()
        {
            IsPass = false;
            Name = Roll.HumanPlayer.ToString();
        }

        public override void DrawCard()
        {
            var card = Shoe.GetCard();
            AddCardInHand(card);
            GetHandInformation(card);
            CalculateTotal(card);
        }
    }
}
