using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using A4___Movie_Library_Assignment.Models;
using Newtonsoft.Json;


namespace A4___Movie_Library_Assignment.Services
{
    public class MainService : IMainService
    {
        public void Invoke()
        {
            //string file = $"{Environment.CurrentDirectory}movies.csv";


            //if (!File.Exists(file))
            //{
            //    Console.WriteLine("Your file doesn't exist");
            //}
            //else
            //{
                string choice;

                Movie movie = new Movie();
                movie.Id = 1;
                movie.Title = "Toy Story (1995)";
                movie.Genre = new string[] { "Adventure", "Children", "Fantasy" };
                string json = JsonConvert.SerializeObject(movie);

                Movie movie2 = new Movie();
                movie.Id = 5;
                movie.Title = "Father of the Bride Part II (1995)";
                movie.Genre = new string[] { "Comedy" };
                string json2 = JsonConvert.SerializeObject(movie2);


                do
                {


                    Console.WriteLine("1) Add Movie");
                    Console.WriteLine("2) Display all movies");
                    Console.WriteLine("Enter to quit");

                    choice = Console.ReadLine();


                    //List<UInt64> MovieIds = new List<UInt64>();
                    //List<string> MovieTitles = new List<string>();
                    //List<string> MovieGenres = new List<string>();

                    //try
                    //{
                    //    StreamReader reader = new StreamReader(file);
                    //    reader.ReadLine();
                    //    while (!reader.EndOfStream)
                    //    {
                    //        string line = reader.ReadLine();
                    //        int idx = line.IndexOf('"');
                    //        if (idx == -1)
                    //        {
                    //            string[] movieDetails = line.Split(',');
                    //            MovieIds.Add(UInt64.Parse(movieDetails[0]));
                    //            MovieTitles.Add(movieDetails[1]);
                    //            MovieGenres.Add(movieDetails[2].Replace("|", ","));
                    //        }
                    //        else
                    //        {

                    //            MovieIds.Add(UInt64.Parse(line.Substring(0, idx - 1)));
                    //            line = line.Substring(idx + 1);
                    //            idx = line.IndexOf('"');
                    //            MovieTitles.Add(line.Substring(0, idx));
                    //            line = line.Substring(idx + 2);
                    //            MovieGenres.Add(line.Replace("|", ", "));
                    //        }
                    //    }
                    //    reader.Close();
                    //}
                    //catch { Console.WriteLine("There was an error"); }

                    //if (choice == "1")
                    //{
                    //    Console.WriteLine("Enter the movie title");
                    //    string movieTitle = Console.ReadLine();
                    //    List<string> LowerCaseMovieTitles = MovieTitles.ConvertAll(t => t.ToLower());
                    //    if (LowerCaseMovieTitles.Contains(movieTitle.ToLower()))
                    //    {
                    //        Console.WriteLine("That movie has already been entered");
                    //    }
                    //    else
                    //    {
                    //        UInt64 movieId = MovieIds.Max() + 1;
                    //        List<string> genres = new List<string>();
                    //        string genre;
                    //        do
                    //        {
                    //            Console.WriteLine("Enter genre (or done to quit)");
                    //            genre = Console.ReadLine();
                    //            if (genre != "done" && genre.Length > 0)
                    //            {
                    //                genres.Add(genre);
                    //            }
                    //        } while (genre != "done");
                    //        if (genres.Count == 0)
                    //        {
                    //            genres.Add("(no genres listed)");
                    //        }
                    //        string genresString = string.Join("|", genres);
                    //        movieTitle = movieTitle.IndexOf(',') != -1 ? $"\"{movieTitle}\"" : movieTitle;
                    //        Console.WriteLine($"{movieId},{movieTitle},{genresString}");
                    //        StreamWriter sw = new StreamWriter(file, true);
                    //        sw.WriteLine($"{movieId},{movieTitle},{genresString}");
                    //        sw.Close();
                    //        MovieIds.Add(movieId);
                    //        MovieTitles.Add(movieTitle);
                    //        MovieGenres.Add(genresString);
                    //    }

                    //}
                    if (choice == "2")
                    {

                            Console.WriteLine(json);
                            Console.WriteLine(json2);
                            //Console.WriteLine($"Genre(s): {MovieGenres[i]}");
                            Console.WriteLine("this worked");
                        
                    }
            } while (choice == "1" || choice == "2");
        }

        }
    }
    public interface IMainService
    {
        void Invoke();
    }


