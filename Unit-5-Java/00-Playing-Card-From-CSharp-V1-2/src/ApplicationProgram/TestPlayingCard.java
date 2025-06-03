package ApplicationProgram;

import PlayingCard.PlayingCard;

public class TestPlayingCard {
    public static void main(String[] args) {

        System.out.println("Hello, World!");


        //define an Ace of Spades
        //Syntax is just like C#
        //ClassName objectName = new ClassName(); //Calling a conmstructor
         PlayingCard aceOfSpades = new PlayingCard(PlayingCard.CardValue.Ace,PlayingCard.CardSuit.Spade);

         System.out.println(aceOfSpades);
    } // End of main() method
} // End of TestPlayingCard CLass