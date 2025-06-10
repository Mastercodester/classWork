

import Pet.Pet;

import java.util.Scanner;

/// give you access to the Pet class stuff




public class Main {
    public static void main(String[] args) {

        System.out.printf("Welcome to Pet Management\n");
=
/// Instantiate a Pet

Pet cat1 = new Pet("James", "Cat", 'M',30, true);



cat1.displayPet();

Scanner theKeyboard = new Scanner(System.in);
/// Instantiate a Pet from Userinput - Java use Scanner for keyboard input

        System.out.print("\n whats is the name of your pet?");
        String thePetName = theKeyboard.nextLine();

        System.out.print("\n whats is the name of your pet?");
        String thePetType = theKeyboard.nextLine();

        System.out.print("\n whats is the name of your pet?");
      String thePetGender = theKeyboard.nextLine();

        System.out.print("\n whats is the name of your pet?");
        String thePetWeight = theKeyboard.nextLine();

        System.out.print("\n whats is the name of your pet?");
        String thePetSpay = theKeyboard.nextLine();

        char petGender = thePetGender.charAt(0);
        int petWeight = Integer.parseInt(thePetWeight);
        boolean petSpayed = false ; /// assume pet is not spayed
        if (thePetSpay.equals("Y")){
            petSpayed = true;
        }


       Pet pet1 = new Pet (thePetName,thePetType,petGender,petWeight,petSpayed);

        pet1.displayPet();

    }///end of main
}/// end of main() class