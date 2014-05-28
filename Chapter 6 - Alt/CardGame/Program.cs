//using statements allow me access to the classes in the stated namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.AdHoc_Demo; // allows acces to the various collection-class demos.
using CardGame.Game_Elements; // allows access to the game elements folder

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunDemos();

            Program myApp = new Program();
            myApp.RunCardDemo();
        }

        public void DisplayPlayerCards(Player person)
        {
            Console.WriteLine("Looking at player's cards...");
            for (int i = 0; i < person.Count; i++)
            {
                Console.WriteLine(person.Peek(i));
            }
            Console.WriteLine();
        }

        public void RunCardDemo()
        {
            Console.WriteLine("Creating deck...");
            DeckOfCards myDeck = new DeckOfCards();
            DisplayCards(myDeck);
            Console.WriteLine();
            Console.WriteLine("Shuffling deck...");
            myDeck.Shuffle();
            DisplayCards(myDeck);
            Console.WriteLine();
            Player me = new Player(), you = new Player(), friend = new Player();
            Console.WriteLine("Dealing out cards to players...");
            Console.WriteLine();
            myDeck.Deal(5, me, you, friend); //because the method parameter includes params of Player[], we can call the method this way 
            //(comma separated list)
            Console.WriteLine("Peeking at my hand...");
            DisplayPlayerCards(me);
            Console.WriteLine("Peeking at your hand...");
            DisplayPlayerCards(you);

            /* Uh-oh, not so secure...
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
             */
            Console.WriteLine("There are {0} cards in the deck", myDeck.Cards.Count);
            //this won't compile
            //myDeck.Cards = new List<Card>();
        }

        static void RunDemos()
        {
            ArrayDemo demo1 = new ArrayDemo();
            demo1.Run();
            ListDemo demo2 = new ListDemo();
            demo2.Run();
            QueueDemo demo3 = new QueueDemo();
            demo3.Run();
            StackDemo demo4 = new StackDemo();
            demo4.Run();
        }

        private static void DisplayCards(DeckOfCards deck)
        {
            // Just display all the cards
            foreach (Card item in deck.Cards)
            {
                Console.WriteLine("{0} of {1}", item.Face, item.Suit);
            }
        }
    }
}
