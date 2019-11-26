using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleDatabase.Models;

namespace VehicleDatabase.ViewModels
{
    public class NewVehicleModelView
    {
        public IEnumerable<VehicleMake> VehicleMakes { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public VehicleMake VehicleMake { get; set; }
    }
}