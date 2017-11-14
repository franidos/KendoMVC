using APi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Model : DbContext
    {
        public Model() : base("name=Prueba")
        {
           
        }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Producto>().HasRequired(x=>x.UserID.Value);
            base.OnModelCreating(modelBuilder);
        }
    }
}