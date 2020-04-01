using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorMovies.Client.Helpers;

namespace BlazorMovies.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{

			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			//Section 27.Dependency Injection
			ConfigureServices(builder.Services);
			builder.RootComponents.Add<App>("app");


			await builder.Build().RunAsync();
		}

		//Section 27.Dependency Injection

		private static void ConfigureServices(IServiceCollection services) 
		{
			services.AddOptions();      //Authorization system
			services.AddSingleton<SingletonService>();
			services.AddTransient<TransientService>();
			services.AddTransient<IRepository, RepositoryInMemory>();
		}
	}
}
