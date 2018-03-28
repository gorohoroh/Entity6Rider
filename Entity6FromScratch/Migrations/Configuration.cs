
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Entity6FromScratch.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Entity6FromScratch.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}