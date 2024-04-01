using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Logic_Business.Repositories;
using BookStore.Logic_Business.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.OpenApi.Models;


namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("BookStoreContextConnection") ?? throw new InvalidOperationException("Connection string 'BookStoreContextConnection' not found.");

            builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddIdentityApiEndpoints<IdentityUser>().AddEntityFrameworkStores<StoreContext>();

            // Add services to the container.
            builder.Services.AddScoped<IBooks, BooksRepository>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            
            
            builder.Services.AddAuthentication();

            builder.Services.AddAuthorization();

          


            //Add Swagger
            builder.Services.AddSwaggerGen(op =>
            {
                op.AddSecurityDefinition("oauth2", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Name = "authorization",
                    Type = SecuritySchemeType.ApiKey,

                });
                op.OperationFilter<SecurityRequirementsOperationFilter>();

            });

            

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.
            app.MapIdentityApi<IdentityUser>();

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
