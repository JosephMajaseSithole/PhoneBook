using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhoneBook.Core.Interfaces;
using PhoneBook.DbLayer;
using PhoneBook.Repository.Repositories;

namespace PhoneBook
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("AllowAll",
						builder =>
						{
							builder
							.AllowAnyOrigin()
							.AllowAnyMethod()
							.AllowAnyHeader();
						});
			});

			services.AddControllers();
			services.AddTransient<IPhoneBookRepository, PhoneBookRepository>();

			services.AddDbContext<PhoneBookDBContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("PhoneBook")));
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{

			app.UseCors("AllowAll");

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
