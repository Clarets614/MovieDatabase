using MovieDatabase;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;



//Movie rotj = new Movie("SW:Return of the Jedi","scifi", 1983, "80's");
//Movie esb = new Movie("SW:Empire Strikes Back", "scifi", 1980, "80's");
//Movie anh = new Movie("SW:A New Hope", "scifi", 1977, "70's");
//Movie aladdin = new Movie("Aladdin", "animated", 1993, "90's");
//Movie lionKing = new Movie("The Lion King", "animated", 1994, "90's");
//Movie frozen = new Movie("Frozen", "animated", 2013, "10's");
//Movie dofd = new Movie("Dawn of the Dead", "horror", 1978, "70's");
//Movie godfather = new Movie("Godfather", "drama", 1972, "70's");
//Movie forrestgump = new Movie("Forrest Gump", "drama", 1994, "90's");
//Movie cmiyc = new Movie("Catch Me If You Can", "drama", 2002, "00's");
//Movie conjuring = new Movie("The Conjuring", "horror", 2013, "10's");
//Movie sotl = new Movie("Silence of the Lambs", "horror", 1991, "90's");

List<Movie> Movies = new List<Movie>
{
    new Movie("SW:Return of the Jedi","scifi", 1983, "80's"),
    new Movie("SW:Empire Strikes Back", "scifi", 1980, "80's"),
    new Movie("SW:A New Hope", "scifi", 1977, "70's"),
    new Movie("Aladdin", "animated", 1993, "90's"),
    new Movie("The Lion King", "animated", 1994, "90's"),
    new Movie("Frozen", "animated", 2013, "10's"),
    new Movie("Dawn of the Dead", "horror", 1978, "70's"),
    new Movie("Godfather", "drama", 1972, "70's"),
    new Movie("Forrest Gump", "drama", 1994, "90's"),
    new Movie("Catch Me If You Can", "drama", 2002, "00's"),
    new Movie("The Conjuring", "horror", 2013, "10's"),
    new Movie("Silence of the Lambs", "horror", 1991, "90's"),
};


//Linq statement to group up the list of movies by category. 




//main program

Console.WriteLine("Welcome to the Movie Database of the Decade");
Console.WriteLine($"There are {Movies.Count} movies in this list");


bool runProgram = true;
while ( runProgram)
{



Console.WriteLine("Choose an option from the following categories\n");

//Linq statement to group up the list of movies by category. It groups them by the movie category attribute and picks the first one in each new attrubute type

var category = Movies.GroupBy(Movie => Movie.Category).Select(category => category.First().Category);
foreach (var c in category)
{
    Console.WriteLine(c);
}
Console.WriteLine("");
string categorychoice = Console.ReadLine().ToLower().Trim();

    List<Movie> result = Movies.Where(movie => movie.Category == categorychoice).ToList();

    foreach (Movie m in result)
    {
        Console.WriteLine($"{m.Title}: {m.Category}");
    }


    Console.WriteLine();

    //ask to continue
    runProgram = ValidateInputs.GetContinue("Would you like to search again?");
}

Console.WriteLine("\nThis is the total list of movies with extra information in case you missed any!");
foreach (Movie movie in Movies.OrderBy(movie => movie.Year))
{

    Console.WriteLine($"{movie.Title}: {movie.Decade}: {movie.Category}");
}

Console.WriteLine("\nGoodBye!");