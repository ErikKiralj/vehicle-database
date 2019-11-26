using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleDatabase.Models;

namespace VehicleDatabase.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public VehicleMake VehicleMake { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public int VehicleMakeId { get; set; }
    }
}