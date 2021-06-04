using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.Entities
{
    public class Trucks
    {
        [Key]
        public int ID { get; set; }
        public ModelEnum Model { get; set; }
        public int YearManufacturing { get; set; }
        public int YearModel { get; set; }
    }

    public enum ModelEnum
    {
        FH,
        FM
    }
}
