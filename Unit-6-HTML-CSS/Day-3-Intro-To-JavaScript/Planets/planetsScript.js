





 const Mercury = { name: "Mercury", inner: true, diameter: 3031.9, color:rgb(69, 69, 69)

}

const Venus = { name: "Venus", inner: true, diameter: 7520.8, color:rgb(b8, 91, 65)

}

const Earth = { name: "Earth", inner: true, diameter: 7917.5, color:rgb(a5, b5, 86)

}

const Mars = { name: "Mars", inner: true, diameter: 4212.3, color:rgb(df, c8, e4)

}

const Jupiter = { name: "Jupiter", inner: false, diameter: 86881, color:rgb(f6, a0, 49)

}

const Saturn = { name: "Saturn", inner: false, diameter: 72367, color:rgb(dc, d3, a1)

}

const Uranus = { name: "Uranus", inner: false, diameter: 31518, color:rgb(b4, d9, df)

}
const Neptune = { name: "Neptune", inner: false, diameter: 30599, color:rgb(45, e6, ff)

}
let index = 0; // Variable to keep track of the current index



// Phase 1: Create an array of objects
// Create an array named planet that contains the objects Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, and Neptune. Each object should have the following properties: name, inner
// (a boolean indicating whether the planet is an inner planet), diameter (the diameter of the planet in miles), and color (a string representing the color of the planet).
// Use the let keyword to declare the array and the const keyword for the objects.

// The objects are created using the const keyword because they are not expected to change.



let planets = [Mercury, Venus, Earth, Mars, Jupiter, Saturn,Uranus, Neptune]; // let is used for variables that can change Displays the elemenst separated by a comma
console.log(`This is a value in array is: ${planets}`);
console.log(planets); // Display the array in a drop-down format in the console

console.table(planets); // Display the array in a table format in the console


//function getAvg(planet){
   // planet
//}

//
//


function avgDiameter(planet){
    let sum = 0
   let  nextsum = 0
    for (dia ; planet;)
    {
     
       
        sum += planet.diameter;
        return  sum;
    }
nextsum = sum / planet.length;
}



//Phase 2: Previous and next buttons
//Add to the HTML two <button>s and a <p> which will hold an index number, like this:

//In JavaScript, create a variable named index which is set to 0.
//Add event handlers to the buttons so that the index variable is incremented or decremented and the <p> is updated with the new number. The next button adds one to index. The previous button subtracts one from index.

function updateIndex() {
  document.getElementById("index").textContent = `Index: ${index + 1} of ${planet.length}`;
}

function next() {
    if (index < planets.length - 1) {
        index++;
        updateIndexDisplay();
        displayPlanetInfo(planets[index]);
    }
    
}

function previous() {
    if (index > 0) {
        index--;
        updateIndexDisplay();
        displayPlanetInfo(planets[index]);
    }
}
window.onload = function () {
    updateIndexDisplay();
    displayPlanetInfo(planets[index]);
};

function displayPlanetInfo(planet) {
    document.getElementById("planetName").innerText = planet.name;
    document.getElementById("planetCircle").style.backgroundColor = planet.color;
    document.getElementById("planetDiameter").innerText = `Diameter: ${planet.diameter} miles`;
    document.getElementById("planetInner").innerText = `Inner Planet: ${planet.inner ? "Yes" : "No"}`;
    document.getElementById("planetColor").innerText = `Color: ${planet.color}`;
    document.getElementById("planetIndex").innerText = `Index: ${index + 1} of ${planet.length}`;
}