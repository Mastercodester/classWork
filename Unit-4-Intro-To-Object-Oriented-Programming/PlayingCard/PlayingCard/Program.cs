﻿namespace PlayingCard;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        PlayingCard aCard = new PlayingCard("Spades", "Black", 1);
        
        
        // Display our card
        Console.WriteLine(aCard);
    }
}