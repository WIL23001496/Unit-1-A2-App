using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    /// <summary>
    /// 
    /// </summary>
    internal class Hand
    {
        private List<PlayingCard> _Cards;//a
        public List<PlayingCard> Cards //b
        {
            get { return _Cards; }
        }

        public int Count //c
        {
            get { return _Cards.Count; }
        }

        public Hand() //d
        {
            _Cards = new List<PlayingCard>();
        }

        public void AddCardToHand(PlayingCard cardToAdd) //e
        {
            _Cards.Add(cardToAdd);
        }//end


        /// <summary>
        /// 
        /// </summary>
        public int Value() //f
        {
            int cardValue = 0;
            int handValue = 0;
            int aces = 0;


            for (int ptr = 0; ptr < _Cards.Count; ptr++)//1
            {
                if (_Cards[ptr].Face == "Ace")
                {
                    cardValue = 11;
                    aces = aces + 1;
                    _Cards[ptr].Value = cardValue;
                }
                else if (_Cards[ptr].Value > 10)
                {
                    cardValue = 10;
                    _Cards[ptr].Value = cardValue;
                }
                else
                {
                    cardValue = _Cards[ptr].Value;
                    _Cards[ptr].Value = cardValue;
                }
                handValue = handValue + cardValue;

            }//end

            while ((handValue > 21)&& (aces > 0))//2
            {
            
                handValue = handValue - 10;
                aces = aces - 1;
            }
            return handValue;
        }


       
    }
}