﻿namespace BlackJackGameCLI.Persons
{
    public class HumanPlayer : Person
    {
        public HumanPlayer()
        {
            IsPass = false;
            Name = Roll.Player.ToString();
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
