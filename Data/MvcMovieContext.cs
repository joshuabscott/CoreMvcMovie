using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMvcMovie.Models;
using MvcMovie.Models;

namespace CoreMvcMovie.Data
{
    public class CoreMvcMovieContext : DbContext
    {
        public CoreMvcMovieContext(DbContextOptions<CoreMvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}