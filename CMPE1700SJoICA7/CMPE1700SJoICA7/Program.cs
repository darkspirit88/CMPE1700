using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMPE1700SJoICA7
{
    public enum Suits
    {
        Clubs, Diamons, Hearts, Spades
    }
    public enum Faces
    {
        Deuce = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
    public struct Cards
    {
        public Suits _suit;
        public Faces _number;
        public Cards(Suits suit, Faces number)
        {
            _suit = suit;
            _number = number;
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", _suit, _number);
        }

    }
    class Program
    {
        static Random generator = new Random();
        
        static void Main(string[] args)
        {
            Stack<Cards> FinalCards = new Stack<Cards>();
            foreach (int suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (int number in Enum.GetValues(typeof(Faces)))
                {
                    FinalCards.Push(new Cards((Suits)suit, (Faces)number));
                }
            }

            for (int i = 0; i < 30; i++)
            {
                Shuffle(ref FinalCards);
            }

            foreach (Cards Cards in FinalCards)
            {
                Console.WriteLine(Cards);
            }
            

            
            Console.ReadKey();
        }
        static void Shuffle(ref Stack<Cards> FinalCards)
        {
            Stack<Cards> DeckOne = new Stack<Cards>();
            Stack<Cards> DeckTwo = new Stack<Cards>();
           
            int split = generator.Next(FinalCards.Count);
            for (int i = 0; i < split; i++)
            {
                DeckOne.Push(FinalCards.Pop());
            }
            while (DeckOne.Count + FinalCards.Count > 0)
            {
                if (DeckOne.Count > 0) DeckTwo.Push(DeckOne.Pop());
                if (FinalCards.Count > 0) DeckTwo.Push(FinalCards.Pop());

            }
            while (DeckTwo.Count > 0)
            {
                if (DeckTwo.Count > 0) FinalCards.Push(DeckTwo.Pop());
            }
        }
    }
}
