namespace BlackJackGameCLI.Persons
{
    public class Croupier : Person
    {
        public Croupier()
        {
            IsPass = false;
            Name = Roll.Croupier.ToString();
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
