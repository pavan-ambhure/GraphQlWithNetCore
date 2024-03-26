using System;
using GraphQLWithNetCore.Dtos;
using GraphQLWithNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLWithNetCore.Services
{
    public class MyDbContext : DbContext
    {
        public static string DbConnectionString = "Server=localhost;Database=TutorialDB;User Id=sa;Password=***;TrustServerCertificate=true";

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        public DbSet<Locations> Location { get; set; }

    }
}

