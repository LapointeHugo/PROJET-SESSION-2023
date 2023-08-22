﻿using ProjetSessionHL.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace ProjetSessionHL.Data
{
    public class ProjetSessionDbContext : DbContext
    {
        public ProjetSessionDbContext(DbContextOptions<ProjetSessionDbContext> options) : base(options) { }

        public DbSet<Enfant> Enfants { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Tournoi> Tournois { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Générer des données de départ
            modelBuilder.GenerateData();
        }
    }
}
