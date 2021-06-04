using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models.Context;

namespace WebApplication.Models
{
    public class MyDbContextSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Trucks.Add(new Entities.Trucks()
            {
                YearManufacturing = 2020,
                YearModel = 2021,
                Model = Entities.ModelEnum.FH
            });
            context.SaveChanges();
        }
    }
}
