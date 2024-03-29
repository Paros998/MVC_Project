using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
        public DbSet<MvcMovie.Models.Student> Student {get;set;}
        public DbSet<MvcMovie.Models.Raport> Raport {get;set;}
        public DbSet<MvcMovie.Models.Produkt> Produkt {get;set;}
    }
