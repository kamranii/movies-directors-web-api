using System;
using MoviesDirectors.Models;

namespace MoviesDirectors.Data;

public class Database
{
	public static List<Movie> movies = new List<Movie>(0);
	public static List<Director> directors = new List<Director>(0);
	public Database()
	{
	}
}

