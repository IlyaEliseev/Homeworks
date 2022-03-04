namespace BlackJackGameCLI.Persons
{
    public class ComputerPlayer : Person
    {
        private static int _playerCount = 1;

        public ComputerPlayer(): base()
        {
            IsPass = false;
            Name = $"{Roll.Computer} {_playerCount++}";
        }
        
        public override bool IsPass { get; protected set; }

        public override void TakeCard()
        {
            if (_total <= 18)
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
