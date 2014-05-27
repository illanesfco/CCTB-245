using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    //Extra data types that relate to the Card class
    enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }
    enum CardFace
    {
        Ace = 1,
        Deuce,
        Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
    }

    class Card
    {
        #region Properties
        public Suit Suit { get; private set; }
        public CardFace Face { get; private set; }
        public int Value {

            get
            {
                int value = (int)Face; // one valid use of casting...
                if (value > 10)
                    value = 10; // Jack, Queen, and King
                return value;
            }
        }
        #endregion

        #region Constructors
        public Card(Suit suit, CardFace face)
        {
            Suit = suit;
            Face = face;
        }
        #endregion
    }
}
