using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class MancareContext : DbContext
    {
        public MancareContext() : base("PetStore") { }
        public DbSet<Ambalaj> Ambalaje { get; set; }
        public DbSet<Animal> Animale { get; set; }
        public DbSet<Compozitie> Compozitii { get; set; }
        public DbSet<Ingredient> Ingrediente { get; set; }
        public DbSet<Mancare> Mancaruri { get; set; }
        public DbSet<Producator> Producatori { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

    }
}