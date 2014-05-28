using CardGame.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Game_Elements
{
    // This class inherits from the Player class, and implements part of the IFishPlayerInterface
    // This is also an abstract class, meaning that I cannot create an instance of AbstractFishPlayer
    class AbstractFishPlayer : Player//, IFishPlayer
    {
        private Stack<Card> PlayerPile { get; set; }

        public AbstractFishPlayer()
        {
            PlayerPile = new Stack<Card>(); //empty stack of cards
        }

        // TODO: Move this class to a separate file
        // this class needs to finish the rest of the implementation for the IFishPlayer. (The PlayerPile property is implemented
        // in the AbstractFishPlayer already.)
        public class ComputerPlayer : AbstractFishPlayer, IFishPlayer
        {
            public void ShowCards()
            {
                Console.WriteLine("Looking at my cards...");
                foreach (var card in Hand)
                    Console.WriteLine(card);
                Console.WriteLine();

            }

            public bool Ask(IFishPlayer playerToAsk)
            {
                //TODO: move this to base class
                Random rnd = new Random();
                Card askedFor = Hand[rnd.Next(Count)]; //pick some random card
                Console.WriteLine("\tDo you have a " + askedFor + "?");
                Card result = playerToAsk.Reply(askedFor);
                if (result != null)
                    return true;
                else
                    return false;
            }

            public Card Reply(Card askedFor)
            {
                Card myReply = null;
                foreach (var card in Hand)
                {
                    
                }
                return myReply;
            }
        }
    }
}
