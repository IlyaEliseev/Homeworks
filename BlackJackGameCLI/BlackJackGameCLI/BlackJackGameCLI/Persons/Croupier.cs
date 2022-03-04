namespace BlackJackGameCLI.Persons
{
    public class Croupier : Person
    {
        public Croupier()
        {
            IsPass = false;
            Name = "Crouper";
        }

        public override bool IsPass { get ; protected set; }

        public override void TakeCard()
        {
            if (_total <= 15)
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
