using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGameCLI
{
    public class Shoe
    {
        List<Card> shoe = new List<Card>();

        //public TEnum[] GetEnumValues<TEnum>() where TEnum: struct
        //{
        //    return (TEnum[])Enum.GetValues(typeof(TEnum).GetEnumValues());
        //}

        public void FillShoe()
        {

            foreach (var item in Enum.GetValues(typeof(CardDeck)))
            {
                shoe.Add(new Card
                {
                    Value = (int)item,
                    Index = item.ToString()

                });
            }

            //for (int i = 0; i < Enum.GetValues(typeof(CardDeck)).Length; i++)
            //{
            //    card.Add(new Card
            //    {
            //        Value = Enum.GetValues(CardDeck),
            //        Index = item.ToString()

            //    });
            //}
        }
    }
}
