using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Logic_Business.Repositories;
using BookStore.Logic_Business.Interfaces;
using Microsoft.AspNetCore.Builder;


namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("BookStoreContextConnection") ?? throw new InvalidOperationException("Connection string 'BookStoreContextConnection' not found.");

            builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<StoreContext>();

            // Add services to the container.
            builder.Services.AddScoped<IBooks, BooksRepository>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            //Add Swagger
            builder.Services.AddSwaggerGen();

            

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
