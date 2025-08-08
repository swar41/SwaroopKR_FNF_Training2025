            using System;
            using System.Collections;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

            namespace SampleConsoleApp1.Assignment
            {
            class MovieDetails
            {
                public int movieID;
                public string mname = string.Empty;
                public string genre = string.Empty;
                public double rating;

                public int MovieID
                {
                    get { return movieID; }
                    set { movieID = value; }
                }
                public string MovieName
                {
                    get { return mname; }
                    set { mname = value ?? string.Empty; }
                }
                public string MovieGenre
                {
                    get { return genre; }
                    set { genre = value ?? string.Empty; }
                }
                public double MovieRating
                {
                    get { return rating; }
                    set { rating = value; }
                }
            }
            class MDB
            {
                private List<MovieDetails> list = new List<MovieDetails>();
                public void addMovie(MovieDetails movie)
                {
                    list.Add(movie);
                    Console.WriteLine("Movie added successfully!!");
                }
                public void removeMovie(MovieDetails movie)
                {
                    var toRemove = list.Find(m => m.MovieName == movie.MovieName);
                    if (toRemove != null)
                    {
                        list.Remove(toRemove);
                        Console.WriteLine("Removed successfully");
                    }
                    else
                    {
                        Console.WriteLine("Movie not found to remove");
                    }
                }
                public void updateMovie(MovieDetails movie)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].MovieName == movie.MovieName)
                        {
                            list[i].MovieGenre = movie.MovieGenre;
                            list[i].MovieRating = movie.MovieRating;
                            Console.WriteLine($"Movie {movie.MovieName} updated successfully.");
                            return;
                        }
                    }
                    Console.WriteLine("No Movie found to Update");
                }
                public void FindMovie(MovieDetails movie)
                {
                    MovieDetails foundMovie = list.Find(m => m.MovieName == movie.MovieName);
                    if (foundMovie != null)
                    {
                        Console.WriteLine($"Movie Found: Name: {foundMovie.MovieName}, Genre: {foundMovie.MovieGenre}, Rating: {foundMovie.MovieRating}");
                    }
                    else
                    {
                        Console.WriteLine("No Movie found with the given name.");
                    }
                }
                public void DisplayMovies()
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No movies in the database.");
                        return;
                    }
                    Console.WriteLine("Movies in the database:");
                    foreach (var movie in list)
                    {
                        Console.WriteLine($"Name: {movie.MovieName}, Genre: {movie.MovieGenre}, Rating: {movie.MovieRating}");
                    }
        }
    }
    
    internal class Assignment5
        {
            static public (string MovieName, string Genre, double Rating) takeInputs()
            {
                Console.Write("Enter Movie Name: ");
                string? addName = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(addName))
                {
                    Console.Write("Movie Name cannot be empty. Enter Movie Name: ");
                    addName = Console.ReadLine();
                }

                Console.Write("Enter Genre: ");
                string? addGenre = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(addGenre))
                {
                    Console.Write("Genre cannot be empty. Enter Genre: ");
                    addGenre = Console.ReadLine();
                }

                Console.Write("Enter Rating: ");
                double addRating;
                while (!double.TryParse(Console.ReadLine(), out addRating))
                {
                    Console.Write("Invalid input. Enter a valid rating: ");
                }
                return (addName, addGenre, addRating);

            }
            static public void NullOrWhites(string input)
            {
                if(string.IsNullOrWhiteSpace(input))
                {
                    throw new Exception("Input cannot be null or whitespace.");
              
                }
            }

            static void Main(string[] args)
            {
                MDB db = new MDB();
                bool flag = true;
                Console.WriteLine("Welcome to the Movie Database!");
                Console.WriteLine("\nMovie Database Menu:");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Update Movie");
                Console.WriteLine("3. Remove Movie");
                Console.WriteLine("4. Find Movie");
                Console.WriteLine("5.Display all movies");
                Console.WriteLine("6. Exit");
            while (flag)
                {
                    Console.Write("Enter your choice: ");
                    string? input = Console.ReadLine();
                    NullOrWhites(input);
                switch (input)
                    {
                        case "1":
                            var (addName, addGenre, addRating) = takeInputs();
                            db.addMovie(new MovieDetails { MovieName = addName, MovieGenre = addGenre, MovieRating = addRating });
                            break;
                        case "2":
                            var (updName, updGenre, updRating) = takeInputs();
                            db.updateMovie(new MovieDetails { MovieName = updName, MovieGenre = updGenre, MovieRating = updRating });
                            break;
                        case "3":
                            Console.Write("Enter Movie Name to Remove: ");
                            string? remName = Console.ReadLine();
                            NullOrWhites(remName);
                            db.removeMovie(new MovieDetails { MovieName = remName });
                            break;
                        case "4":
                            Console.Write("Enter Movie Name to Find: ");
                            string? findName = Console.ReadLine();
                            NullOrWhites(findName);
                            db.FindMovie(new MovieDetails { MovieName = findName });
                            break;
                        case "5":
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
        
            }
        }
                }
