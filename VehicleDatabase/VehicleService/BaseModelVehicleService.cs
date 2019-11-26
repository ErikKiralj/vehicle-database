using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VehicleDatabase.Models;
using VehicleDatabase.ViewModels;
using PagedList;
using PagedList.Mvc;

namespace VehicleDatabase.VehicleService
{
    public abstract class BaseModelVehicleService :Controller
    {
        public abstract List<VehicleModel> Index(string sortOrder, string searchString, int? page);

        public abstract void Save(VehicleModel vehiclemodel);

        public abstract NewVehicleModelView Edit(int id);

        public abstract void Delete(int id);

        public abstract NewVehicleModelView New();
    }
}