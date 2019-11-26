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
using AutoMapper;
using VehicleDatabase.Dtos;

namespace VehicleDatabase.VehicleService
{
    public class VehicleModelService : BaseModelVehicleService
    {
        private ApplicationDbContext _context;

        public VehicleModelService()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public override List<VehicleModel> Index(string sortOrder, string searchString, int? page)
        {
            var models = _context.VehicleModels.Include(m => m.VehicleMake).ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                models = models.Where(m => m.Name.Contains(searchString)).ToList();
            }

            if (sortOrder == "AscendingMakeName")
            {
                models.Sort((m1, m2) => string.Compare(m1.VehicleMake.Name, m2.VehicleMake.Name));
                return models;
            }

            else if ((sortOrder == "DescendingMakeName"))
            {
                models.Sort((m1, m2) => string.Compare(m1.VehicleMake.Name, m2.VehicleMake.Name));
                models.Reverse();
                return models;
            }

            if (sortOrder == "AscendingModelName")
            {
                models.Sort((m1, m2) => string.Compare(m1.Name, m2.Name));
                return models;
            }

            else if ((sortOrder == "DescendingModelName"))
            {
                models.Sort((m1, m2) => string.Compare(m1.Name, m2.Name));
                models.Reverse();
                return models;
            }
            else

                return models;
        }

        public override void Delete(int id)
        {
            var vehiclemodelInDb = _context.VehicleModels.Single(c => c.Id == id);

            _context.VehicleModels.Remove(vehiclemodelInDb);
            _context.SaveChanges();
        }

        public override NewVehicleModelView New()
        {
            var makes = _context.VehicleMakes.ToList();

            var viewModel = new NewVehicleModelView
            {
                VehicleMakes = makes,
            };

            return viewModel;
        }

        public override void Save(VehicleModel vehiclemodel)
        {
            if (vehiclemodel.Id == 0)
            {
                _context.VehicleModels.Add(vehiclemodel);
            }

            else
            {
                var vehiclemodelInDb = _context.VehicleModels.Single(c => c.Id == vehiclemodel.Id);

                vehiclemodelInDb.Name = vehiclemodel.Name;
                vehiclemodelInDb.Abrv = vehiclemodel.Abrv;
            }

            _context.SaveChanges();
        }

        public override NewVehicleModelView Edit(int id)
        {
            var vehiclemodel = _context.VehicleModels.SingleOrDefault(c => c.Id == id);
            var make = _context.VehicleMakes.Single(c => c.Id == vehiclemodel.VehicleMakeId);

            

            var viewModel = new NewVehicleModelView
            {
                VehicleMake = make,
                VehicleModel = vehiclemodel
            };

            return viewModel;
        }

    }
}