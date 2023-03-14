using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4___Movie_Library_Assignment
{
    public class Read
    {
        Console.WriteLine("Enter the movie title");
                        string movieTitle = Console.ReadLine();
        List<string> LowerCaseMovieTitles = MovieTitles.ConvertAll(t => t.ToLower());
                        if (LowerCaseMovieTitles.Contains(movieTitle.ToLower()))
                        {
                            Console.WriteLine("That movie has already been entered");
                        }
                        else
                        {
                            UInt64 movieId = MovieIds.Max() + 1;
    List<string> genres = new List<string>();
    string genre;
                            do
                            {
                                Console.WriteLine("Enter genre (or done to quit)");
                                genre = Console.ReadLine();
                                if (genre != "done" && genre.Length > 0)
                                {
                                    genres.Add(genre);
                                }
                            } while (genre != "done") ;
if (genres.Count == 0)
{
    genres.Add("(no genres listed)");
}
string genresString = string.Join("|", genres);
movieTitle = movieTitle.IndexOf(',') != -1 ? $"\"{movieTitle}\"" : movieTitle;
Console.WriteLine($"{movieId},{movieTitle},{genresString}");
StreamWriter sw = new StreamWriter(file, true);
sw.WriteLine($"{movieId},{movieTitle},{genresString}");
sw.Close();
MovieIds.Add(movieId);
MovieTitles.Add(movieTitle);
MovieGenres.Add(genresString);
                        }

    }
}
