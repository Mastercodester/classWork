//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Iterator;
import java.util.Map;
import java.util.HashMap;
import java.util.TreeMap;
import java.util.LinkedHashMap;

///Create a Map to hold a persons name and their favorite number
///



public class Main {
    public static void main(String[] args) {



///Map<String, Integer> peoplesNumbers = new HashMap<>(); /// HAsh map stores in random order
     ///   Map<String, Integer> peoplesNumbers = new TreeMap<>();/// treemap stores by key type
        Map<String, Integer> peoplesNumbers = new LinkedHashMap<>();/// Linkedap stores by entry



///  .put(key, value )
peoplesNumbers.put("Jake", 42);


/// Find an entry in the Map
        /// .get(key-value) retrieve the value associated with the key - null if key is not in the Map

System.out.println(peoplesNumbers.get("Jake"));


        /// display all the netries in the map
        /// entrySet()returns a Set of entries in from the Map
        ///Each itemm in the entrySet is a key-value pair
        ///  USe setElement.getKey() to retrieve the value of the key
        ///  Use setElement.getValue to retrieve the value associated with the key

        for(Map.Entry<String, Integer> entry :peoplesNumbers.entrySet()){
            System.out.println("Name;" + entry.getKey() + "favorite number:" + entry.getValue());
        }

        peoplesNumbers.remove("Jake");



    }





    /// End of Main
}