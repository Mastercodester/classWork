using Day_5_Inheritance_Example;

namespace Day_5_Inheritaance_Example;
// this is a subclass of playingcard
public class ItailanPlayingCard : PlayingCard
{
    //Define a default construcyor that calls the base class constructor

    public ItailanPlayingCard() : base(0, "joker", "Black")
    {
    }
    // define a 2 arg ctor for value and suit
    public ItailanPlayingCard(int theValue, string theSuit, string theColor):base(theValue, theSuit, theColor)
    {
    }
    
}