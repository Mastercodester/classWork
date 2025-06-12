namespace MoviesList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start of MoviesList");
        
        List<Movie> movies = new List<Movie>();



        Movie movie1 = new Movie("Star Wars", "Fiction");
        Movie movie2 = new Movie("Scarface", "Action");
        Movie movie3 = new Movie("CloverField", "Horror");
        Movie movie4 = new Movie("Scary Movie", "Comedy");
        Movie movie5 = new Movie("Friday", "comedy");
        Movie movie6 = new Movie("Last Sunday", "comedy");
        Movie movie7 = new Movie("Family Guy", "comedy");
        Movie movie8 = new Movie("Death RAce", "action");
        Movie movie9 = new Movie("Pineapple express", "comedy");
        Movie movie10 = new Movie("The interview", "comedy");


movies.Add(movie1);
movies.Add(movie2);
movies.Add(movie3);
movies.Add(movie4);
movies.Add(movie5);
movies.Add(movie6);
movies.Add(movie7);
movies.Add(movie8);
movies.Add(movie9);
movies.Add(movie10);




Console.WriteLine("Enter a Category");
string input = Console.ReadLine();
     
  
findMovie(movies, input);


    }
    
    
    public static void findMovie(List<Movie> movies, string Input){
        string result = "";
        foreach ( Movie movie2 in movies){

            if (movie2.category == Input)
            {
                result += movie2.title + ", ";
                Console.WriteLine(result);
               
            }
            
            
           
            
        }


         
         
     
    }

}