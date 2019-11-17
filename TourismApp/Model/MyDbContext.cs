using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TourismApp.Model
{
    class MyDbContext : DbContext
    { 
     
            public MyDbContext() : base("TourismBD")
             { }
            

        public DbSet<User> Users { get; set; }
        public DbSet<Lieu> Lieu { get; set; }
    }
    }


