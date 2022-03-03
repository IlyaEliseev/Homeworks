namespace BlackJackGameCLI.Persons
{
    public class Croupier : Person
    {
        public Croupier()
        {
            IsPass = false;
            Name = "Crouper: ";
        }

        public override bool IsPass { get ; set ; }

        public override void TakeCard()
        {
            if (Total <= 15)
            {
                var card = Shoe.GetCard();
                AddCardInHand(card);
                GetHandInformation(card);
                CalculateTotal(card);
            }
            else
            {
                SayPass();
            }
        }
    }
}
