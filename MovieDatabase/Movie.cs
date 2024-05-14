using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Decade { get; set; }



    //constructor

        public Movie(string _title, string _category, int _year, string _decade)
        {
            Title = _title;
            Category = _category;
            Year = _year;
            Decade = _decade;
        }

        //methods

//tried out things in methods for a bit
        public string ShowInfo()
        {
            string title = Title;
            string category = Category;
            int year = Year;
            string decade = Decade;
            return $"{title}: {category}: {year} : {decade}";

        }

        public void GroupbyCategory(List<Movie>movies)
        {
            var groupedMovies = movies.GroupBy(movie => movie.Category);
            foreach (var group in groupedMovies)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var movie in group)
                {
                    Console.WriteLine($"Title {movie.Title}");
                }
            }
        }

        public static bool GetuserInput(string userInput)
        {
            //string category = Category;
            if (userInput == "yes")
            {
                return false;
            }
            else
            {
                return true;
            }
        }




    }





}
