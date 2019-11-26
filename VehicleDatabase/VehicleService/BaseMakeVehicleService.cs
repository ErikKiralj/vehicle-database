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
    public abstract class BaseMakeVehicleService : Controller
    {
        public abstract List<VehicleMake> Index(string sortOrder, string searchString, int? page);

        public abstract void Save(VehicleMake vehiclemake);

        public abstract VehicleMake Edit(int id);

        public abstract void Delete(int id);
    }
}