namespace BlackJackGameCLI
{
    public class Shoe
    {
        private static readonly List<Card> shoe = new List<Card>();

        Dictionary<string, int> cardsDeck = CardsDeck.GetCardsDeck();

        public void FillShoe()
        {

            foreach (var card in cardsDeck)
            {
                shoe.Add(new Card
                {
                    Value = card.Value,
                    Index = card.Key.ToString()
                });
            }
        }

        public static Card GetCard()
        {
            Random random = new Random();
            return shoe[random.Next(0, shoe.Count + 1)];
        }
    }
}
