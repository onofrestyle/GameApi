using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameApi.Infrastructure.Data
{
    public class SqliteContext: DbContext
    {
        public SqliteContext( DbContextOptions<SqliteContext> options )
            : base(options)
        {

        }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<Game> Game { get; set; }
    }
}
