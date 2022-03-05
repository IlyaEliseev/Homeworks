namespace BlackJackGameCLI
{
    public class Shoe
    {
        private static readonly int _countDecks = 4;

        private static readonly List<Card> _shoe = new List<Card>();

        private static readonly Dictionary<string, int> _cardsDeck = CardsDeck.GetCardsDeck();

        public static bool FillShoe()
        {
            for (int i = 0; i < _countDecks; i++)
            {
                foreach (var card in _cardsDeck)
                {
                    _shoe.Add(new Card
                    {
                        Value = card.Value,
                        Index = card.Key.ToString()
                    });
                }
            }

            return true;
        }

        public static Card GetCard()
        {
            Random random = new Random();

            var aviableShoe = _shoe
                .Where(x => x.IsAviable == true)
                .ToList();

            var card = aviableShoe[random.Next(0, aviableShoe.Count)];
            card.IsAviable = false;

            return card;
        }
    }
}
