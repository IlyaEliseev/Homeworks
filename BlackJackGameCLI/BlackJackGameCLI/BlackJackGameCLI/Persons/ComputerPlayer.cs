namespace BlackJackGameCLI.Persons
{
    public class ComputerPlayer : Person
    {
        private static int _playerCount = 1;

        public ComputerPlayer(): base()
        {
            IsPass = false;
            Name = $"Computer {_playerCount++}: ";
        }
        
        public override bool IsPass { get; set; }

        public override void TakeCard()
        {
            if (Total <= 18)
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
