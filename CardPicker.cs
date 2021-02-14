﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        /// <summary>
        /// Picks a number of cards and return them.
        /// </summary>
        /// <param name="numberSomeCards">The number of cards to pick.</param>
        /// <returns>An array of strings that contain the card names.</returns>
        public static string[] PickSomeCards(int numberSomeCards)
        {
            string[] pickedCards = new string[numberSomeCards];
            
            for (int i = 0; i < numberSomeCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }
    }
}
