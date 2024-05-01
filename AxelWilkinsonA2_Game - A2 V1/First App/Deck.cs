using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    /// <summary>
    /// Create a Deck of 52 Playing Cards and in order by suit and then shuffles them 
    /// a. Defines Attribute _Cards to hold Cards
    /// b. Defines  Property Cards to give access to _Cards
    /// c. Defines Public Property that returns number of cards in Deck
    /// d. Public Method to add playing cards to the Deck
    /// e. Public constructor to make Deck of 52 cars and then shuffle them into a random order
    /// f. Deals a Playing Card from the top of the Deck by returning it and then removing it from the Deck
    /// g. Creates a Random Object
    /// h. Shuffles the cards 1 at a time into a new order one ata time by randomly transfering cards to a new temporary deck
    /// </summary>
    public class Deck
    {
        private List<PlayingCard> _Cards;//a


        public List<PlayingCard> Cards//b
        {
            get { return _Cards; }
        }


        public int Count
        {
            get { return _Cards.Count; }//c
        }

        public void Add(PlayingCard cardToAdd)//d
        {
            _Cards.Add(cardToAdd);
        }//End Add

        public Deck()//e
        {
            _Cards = new List<PlayingCard>();//1
            foreach (String suit in PlayingCard.Suits)
                foreach (String face in PlayingCard.Faces)
                    _Cards.Add(new PlayingCard(suit, face));

            Shuffle();//3
        }//End of Deck Constructor


        public PlayingCard Deal()    //f
        {
            PlayingCard cardToDeal = _Cards[0]; //1
            _Cards.RemoveAt(0); //2
            return cardToDeal;
        }

        private Random rndObject = new Random(Guid.NewGuid().GetHashCode());//G 

        /// <summary>
        /// shuffles the cards 1 at a time into a new order by
        /// 1.Creates newDeck object containing blank list of playing cards
        /// 2.While cards exist in the Deck it will
        /// 3.randomly selecting a card from old Deck
        /// and 4.moving it to the new deck. 
        /// then 5. removes it from the old deck
        /// 6. Transfers cards from newDeck object to _Cards object
        /// </summary>
        private void Shuffle() //4 used in h
        {
            List<PlayingCard> newDeck = new List<PlayingCard>();//1
            while (_Cards.Count > 0)//2
            {
                int cardToMove = rndObject.Next(_Cards.Count);//3
                newDeck.Add(_Cards[cardToMove]);//4
                _Cards.RemoveAt(cardToMove);//5
            }
            _Cards = newDeck;//6
        }//End Shuffle




     //End of Deck Class
    }
}
