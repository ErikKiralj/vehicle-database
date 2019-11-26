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
    public class VehicleMakeService : BaseMakeVehicleService
    {
        private ApplicationDbContext _context;

        public VehicleMakeService()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public override List<VehicleMake> Index(string sortOrder, string searchString, int? page)
        {
            var makes = _context.VehicleMakes.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                makes = makes.Where(m => m.Name.Contains(searchString)
                || m.Abrv.Contains(searchString)).ToList();
            }

            if (sortOrder == "Ascending")
            {
                makes.Sort((m1, m2) => string.Compare(m1.Name, m2.Name));
                return makes;
            }

            else if ((sortOrder == "Descending"))
            {
                makes.Sort((m1, m2) => string.Compare(m1.Name, m2.Name));
                makes.Reverse();
                return makes;
            }
            else

                return makes;

        }

        public override void Save(VehicleMake vehiclemake)
        {
            if (vehiclemake.Id == 0)
            {
                _context.VehicleMakes.Add(vehiclemake);
            }

            else
            {
                var vehiclemakeInDb = _context.VehicleMakes.Single(c => c.Id == vehiclemake.Id);

                vehiclemakeInDb.Name = vehiclemake.Name;
                vehiclemakeInDb.Abrv = vehiclemake.Abrv;
            }

            _context.SaveChanges();
        }

        public override VehicleMake Edit(int id)
        {
            var vehiclemake = _context.VehicleMakes.SingleOrDefault(c => c.Id == id);
            return vehiclemake;

        }

        public override void Delete(int id)
        {
            var vehiclemakeInDb = _context.VehicleMakes.Single(c => c.Id == id);

            _context.VehicleMakes.Remove(vehiclemakeInDb);
            _context.VehicleModels.RemoveRange(_context.VehicleModels.Where(m => m.VehicleMakeId == id));
            _context.SaveChanges();
        }
    }
}