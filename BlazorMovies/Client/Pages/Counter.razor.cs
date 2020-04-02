using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
	public partial class Counter
	{
        [Inject] SingletonService singletion { get; set; }
        [Inject] TransientService transient { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singletion.Value = currentCount;
        }

        private List<Movie> movies;

        protected override void OnInitialized()
        {
            movies = new List<Movie>();
            for (int i = 0; i <= 4; i++)
            {


                Movie movie = new Movie();
                movie.Title = "Counter " + i;
                movie.ReleaseDate = DateTime.Now;
                movies.Add(movie);
            }
        }
    }
}
