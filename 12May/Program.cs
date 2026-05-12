using System.Xml.Serialization;

namespace XMLSerialization;

public class Movie
{
  private string _name;
  private int _duration;
  private int[] _rating;

  public string Name => _name;
  public int Duration => _duration;
  public int[] Rating => _rating.ToArray();

  public Movie(string name, int duration)
  {
    _name = name;
    _duration = duration;
    _rating = new int[0];
  }

  public void Add(int mark)
  {
    _rating = _rating.Append(mark).ToArray();
  }
}

public class MovieDTO
{
  public string Name {get; set;}
  public int Duration {get; set;}
  public int[] Rating {get; set;}
  public MovieDTO(){}

  public MovieDTO(string name, int duration, int[] rating)
  {
    Name = name;
    Duration = duration;
    Rating = rating;
  }

  public static MovieDTO ToDTO(Movie movie)
  {
    return new MovieDTO(
	movie.Name,
	movie.Duration,
	movie.Rating
	);
  }

  public static Movie ToMovie(MovieDTO movieDTO)
  {
    Movie mov = new Movie(
	movieDTO.Name,
	movieDTO.Duration
	);
    foreach(int mark in movieDTO.Rating) mov.Add(mark);
    return mov;
  }

  public MovieDTO(Movie movie)
  {
    Name = movie.Name;
    Duration = movie.Duration;
    Rating = movie.Rating;
  }
}

internal class Program
{
  static void Main(string[] args)
  {
    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string filePath = Path.Combine(folderPath, "Movie.xml");

    Movie movie1 = new Movie("1+1", 130);
    Movie movie2 = new Movie("Interstellar", 220);

    movie2.Add(5);
    movie2.Add(4);
    movie2.Add(3);
    movie2.Add(5);

    movie1.Add(4);
    movie1.Add(2);
    movie1.Add(3);

    var serializer = new XmlSerializer(typeof(MovieDTO));

    Movie movie_prev = movie1;
    using (var writer = new StreamWriter(filePath))
    {
      serializer.Serialize(writer, MovieDTO.ToDTO(movie_prev));
    }


    MovieDTO movieDTO;
    using (var reader = new StreamReader(filePath))
    {
      movieDTO = (MovieDTO)serializer.Deserialize(reader);
    }


    Movie movie_past = MovieDTO.ToMovie(movieDTO);
    System.Console.WriteLine(CompareMovies(movie_prev, movie_past));
  }

  public static bool CompareMovies(Movie m1, Movie m2)
  {
    if (m1.Name != m2.Name) return false;
    if (m1.Duration != m2.Duration) return false;
    if (m1.Rating.Length != m2.Rating.Length) return false;
    for (int i = 0; i < m1.Rating.Length; i++)
    {
      if (m1.Rating[i] != m2.Rating[i]) return false;
    }
    return true;
  }
}
