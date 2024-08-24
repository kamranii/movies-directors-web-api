using System;
namespace MoviesDirectors.Models
{
	public class Movie
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Genre { get; set; }
		public DateTime CreationDate { get; set; }
		public int DirectorID { get; set; }
		public Movie(int id, string name, string genre, int directorId)
		{
			this.ID = id;
			this.Name = name;
			this.Genre = genre;
			this.DirectorID = directorId;
			CreationDate = DateTime.Now;
		}
	}
}

