using System;
namespace MoviesDirectors.Models
{
	public class Director
	{
		public int ID { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Surname { get; set; }
		public int Age { get; set; }
		public Director(int id, string name, string surname, int age)
		{
			this.ID = id;
			this.Name = name;
			this.Surname = surname;
			this.Age = age;
		}
	}
}

