import java.util.Scanner;
import java.util.HashMap;
import java.util.Map;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;
//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<String> familyNames = new ArrayList();
        Set<String> flavors = new LinkedHashSet<>();
        Map<String, Integer> votes = new HashMap<>();

        boolean validResponse = true;
        int maxVotes = 0;

        addNames(familyNames);
        addFlavors(flavors);
        System.out.println("Let's vote on ice cream flavors. Here are your options: " + flavors);


        while (true){for (String member : familyNames){

            boolean next = false;

            while (next == false) {
                System.out.print("\nWhich flavor do you want to vote for "+ member + "?");
                String input = scanner.nextLine().trim().toLowerCase();
                if (flavors.contains(input)) {

                    switch (input) {
                        case "strawberry":
                        case "mint chocolate chip":
                        case "vanilla":
                        case "chocolate":
                        case "cookie dough":

                            String flavor = input.substring(0, 1).toUpperCase() + input.substring(1);
                            votes.put(flavor, votes.getOrDefault(flavor, 0) + 1);
                            System.out.print("You voted for " + flavor + "!\n");
                            next = true;

                            break;
                        default:
                            System.out.print("Invalid flavor.");
                            continue;
                    }
                    break;
                }
                else{
                    System.out.print("Invalid flavor.");
                }
            }




        }



            showTopFlavors(maxVotes,votes);

        }




    }

    public static void addNames(List<String> familyNames){


        familyNames.add("tiki");
        familyNames.add("barber");
        familyNames.add("melo");
        familyNames.add("bron");
        familyNames.add("TO");


    };
    public static void addFlavors(Set<String> flavors){

        flavors.add("strawberry");
        flavors.add("mint chocolate chip");
        flavors.add("vanilla");
        flavors.add("chocolate");
        flavors.add("cookie dough");
    };


    public static void showTopFlavors(int maxVotes,  Map<String, Integer> votes){


        for (int votes2 : votes.values()){
            if (votes2> maxVotes){
                maxVotes = votes2;
            }
        }

        List<String> topFlavors = new ArrayList<>();
        for (Map.Entry<String, Integer> entry : votes.entrySet()) {
            if(entry.getValue() == maxVotes){
                topFlavors.add(entry.getKey());
            }
        }
        System.out.println("\nTop Flavor(s):");
        for (String flavor : topFlavors) {
            System.out.println(flavor + " with " + maxVotes + " vote(s)");
        }
    }

}