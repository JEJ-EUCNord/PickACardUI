using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    public class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            String[] pickedCards = new String[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomSuit() + " " + RandomValue();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // Skaf et tilfældigt tal mellem 1 og 4
            int value = random.Next(1, 5);
            // Er tallet 1, så returner Spar
            if (value == 1)
            {
                return "Spar";
            }
            // Er tallet 2, så returner Hjerter
            if (value == 2)
            {
                return "Hjerter";
            }
            // Er tallet 3, så returner Klør
            if (value == 1)
            {
                return "Klør";
            }
            // Har vi ikke allerede returneret en værdi, er der kun Ruder tilbage
            return "Ruder";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Es";
            if (value == 11) return "Knægt";
            if (value == 12) return "Dronning";
            if (value == 13) return "Konge";
            return value.ToString();
        }
    }
}
