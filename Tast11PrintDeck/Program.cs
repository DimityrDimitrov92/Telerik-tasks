using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        //Print Deck
        //Write a program that reads a card sign(as a string) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers).The cards should be printed using the classical notation(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

        //The card faces should start from 2 to A(10 is 10).
        //Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
        //Input
        //On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
        //Output
        //The output should follow the format bellow(assume our input is 5):
        //2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
        //3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
        //...
        //5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds
        //Constraints
        //The input character will always be a valid card sign.
        //Time limit: 0.1s
        //Memory limit: 16MB
        //Sample tests
        //| Input | Output | | ----------------| ----------------| | 5 | 2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
        //3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
        //...
        //5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds|

        string[] cards = new string[] { "2","3", "4", "5", "6'", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string input = Console.ReadLine();

        for (int i = 0; i < cards.Length; i++)
        {
            Console.Write("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
            Console.WriteLine();
            if (cards[i] == input)
            {
                break;
            }
        }
    }
}