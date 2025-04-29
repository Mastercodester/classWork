using System.Net.Http.Headers;

namespace PlayingCard;

public class PlayingCard
{
    /*
     * data for the class - Instance data
     *
     * Instance data means every object has it's own copy of the data
     */

    private string suit;
     private string color;
   
    
    //
     private int value;// 1,2,3,4,5,6,7,8,9,10,11,12,13
    
    // constructor for PlayingCard - get all the values from the user
    public PlayingCard(string suit, string color, int value)
    {
        thesuit = suit;
        value = theValue;
        color = thecolor;

    }
    
// ToString() so we can use a PlayingCard aS string

    public override string ToString()
    {
        return $"Value: {value} Color: {color} Suit: {
        suit}";
    }
}