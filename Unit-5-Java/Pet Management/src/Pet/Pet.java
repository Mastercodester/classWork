
///Every class in Java is part of a package
///First thing you do to create a new class is create a new package
package Pet;

import java.util.Objects;

/*******************************************************************************
 * This class will represent Pet information for pet
 *
 *
 * Data: Name of the Pet
 *          Type of Pet (Dog, Cat, Gerbil, Lizard, Bird etc
 *          Gender
 *          Weight
 *          Is it Spayed or neutered?
 *
 *          Behavior (methods):
 *
 *          1.You should always have at least 1 constructor to the class
 *                      a default constructor (in case Java needs it; Java uses the default constructor)
 *                                                                      behind the scenes if needed
 *                      ( Usually you have a default constructor that takes arguments used to init the object. )
 *
 *
 *           2. Getters and Setters to allow controlled access to private data member (Encapsulation)
 *
 *
 * 3. Object methods overrides to get the behavior you want from the methods:
 *
 *
 * toString() -Represent the class data as a String
 * equals() - To determine if two objects of the class are equal based on their content
 *                          rather than based on their location in memeory
 *
 *  hashCode() - To generate a hash code based on the content of the object not
 *                                                      it's location memory
 *                                        the same data members used in equals should be used HashCode() so
 *                                        objects that are equal have equal hash code
 *
 *
 *  4. Additional methods to support the class (e.g display method)
 *
 *
 *  A class that has data and methods in items 1 thru 3 is known as
 *  POJO(Plain old java object)
 *
 ********************************************************************************/



public class Pet {

    /**************************************************************************
     * Member Data
     *
     *
     *
     *
      *************************************************************************/

    private String petName;
    private String petType;
    private char petGender;
    private int petWeight;

    private boolean isSpayed;
    //End of pet class


    /******************************************************************************************
     *
     * Constructor init objects  instantiated for a class
     *
     *****************************************************************************************/

    /// Default constructor - define an empty object (we don't know default info)

    public Pet(){

    }

    public Pet(String petName, String petType, char petGender, int petWeight, boolean isSpayed) {



        ///"this is needed because the parameter names are the same as the data member names this is used to refernce the data member and not the parameter names"

        this.petName = petName;
        this.petType = petType;
        this.petGender = petGender;
        this.petWeight = petWeight;
        this.isSpayed = isSpayed;
    }

    /************************************************************
     *
     * Standard getters and setters to allow controlled access to private data members
     *
     * Standard names: getters - getVariableName  setters: setVariableName
     *
     ************************************************************/
    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String petType) {
        this.petType = petType;
    }

    public char getPetGender() {
        return petGender;
    }

    public void setPetGender(char petGender) {
        this.petGender = petGender;
    }

    public int getPetWeight() {
        return petWeight;
    }

    public void setPetWeight(int petWeight) {
        this.petWeight = petWeight;
    }

    public boolean isSpayed() {
        return isSpayed;
    }

    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }



    /**************************************************************************
     * Object method overrides
     *
     * toString() -Represent the class data as a String
     *  equals() - To determine if two objects of the class are equal based on their content
     *                           rather than based on their location in memeory
     *
     *   hashCode() - To generate a hash code based on the content of the object not
     *                                                       it's location memory
     *                                         the same data members used in equals should be used HashCode() so
     *                                         objects that are equal have equal hash code
     *
     *
     *************************************************************************/
    @Override
    /// equals receives a generic Object - Not a object of the class
    /// we have to check or cast the generic object to an object of the class
    /// Usage: aPet.equals(anotherPet) - in the method aPet is assumed and represents the other pet
    public boolean equals(Object o) {
        /// a object called pet is instantiated as part of it
        ///  (o instance of Pet pet) - the Pet pet instantiate a Pet object called pet
        if (!(o instanceof Pet pet)) return false;
        return getPetGender() == pet.getPetGender()     /// Compare the object to left of equals to object inside the ()
                && getPetWeight() == pet.getPetWeight()
                && isSpayed() == pet.isSpayed()
                && Objects.equals(getPetName(), pet.getPetName())
                && Objects.equals(getPetType(), pet.getPetType());
    }

    @Override
    public int hashCode()///  uses the built-in hash() method to generate a hash code using
    {
        return Objects.hash(getPetName(), getPetType(), getPetGender(), getPetWeight(), isSpayed());
    }

    @Override /// Asks the complier to check to be sure this is a valid overrride
    public String toString() {
        return "Pet{" +
                "petName='" + petName + '\'' +
                ", petType='" + petType + '\'' +
                ", petGender=" + petGender +
                ", petWeight=" + petWeight +
                ", isSpayed=" + isSpayed +
                '}';
    }

    /**************************************************************************
     * Additional methods to support the class
     *
     *
     *
     *
     *************************************************************************/


    public void displayPet(){
        System.out.print(this);
    }









///End of PetCLass
}
