using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Game_Elements
{
    //Extra data types that relate to the Card class
    public enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }
    public enum CardFace
    {
        Ace = 1,
        Deuce,
        Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
    }

    // An Immutable type - cannot be changed
    public class Card
    {
        #region Properties
        public Suit Suit { get; private set; }
        public CardFace Face { get; private set; }
        public int Value
        {

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

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
}
