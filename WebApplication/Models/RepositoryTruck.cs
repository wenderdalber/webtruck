using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models.Context;
using WebApplication.Models.Entities;

namespace WebApplication.Models
{
    public class RepositoryTruck
    {
        public string Add(int yearModel, string yearManufac, int model)
        {
            try
            {
                var context = new ApplicationDbContext();
                var _object = new Trucks
                {
                    YearManufacturing = Convert.ToInt32(yearManufac),
                    YearModel = yearModel,
                    Model = (ModelEnum)model
                };
                context.Trucks.Add(_object);
                context.SaveChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "error";
            }
        }

        public string Update(int Id, int yearModel, int yearManufac, int model)
        {
            try
            {
                var context = new ApplicationDbContext();
                var _object = context.Trucks.FirstOrDefault(x => x.ID == Id);

                _object.YearManufacturing = yearManufac;
                _object.YearModel = yearModel;
                _object.Model = (ModelEnum)model;

                context.Entry(_object).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "error";
            }
        }

        public string Delete(int id)
        {
            try
            {
                var context = new ApplicationDbContext();
                var _object = context.Trucks.FirstOrDefault(x => x.ID == id);
                context.Trucks.Remove(_object);
                context.SaveChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "error";
            }
        }

        public Trucks Get(int id)
        {
            var context = new ApplicationDbContext();
            return context.Trucks.FirstOrDefault(x => x.ID == id);
        }
        public List<Trucks> GetAll()
        {
            var context = new ApplicationDbContext();
            return context.Trucks.ToList();
        }
    }
}
