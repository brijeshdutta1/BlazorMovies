using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
	public class RepositoryInMemory : IRepository
	{
		public List<Movie> GetMovies()
		{
			return new List<Movie>()
			{
				new Movie(){ Title="SM",ReleaseDate=DateTime.Now},
				new Movie(){ Title="SM-1",ReleaseDate=DateTime.Now},
				new Movie(){ Title="SM-2",ReleaseDate=DateTime.Now},
			};
		}
	}
}
