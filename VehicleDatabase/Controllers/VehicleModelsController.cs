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
using VehicleDatabase.VehicleService;

namespace VehicleDatabase.Controllers
{
    public class VehicleModelsController : Controller
    {

        public ActionResult Index(string sortOrder, string searchString, int? page)
        {
            BaseModelVehicleService models = new VehicleModelService();
            var modelsToDisplay = models.Index(sortOrder, searchString, page);
            
            return View(modelsToDisplay.ToPagedList(page ?? 1, 5));
        }

        public ActionResult Delete(int id)
        {
            BaseModelVehicleService modelToDelete = new VehicleModelService();
            modelToDelete.Delete(id);

            return RedirectToAction("Index", "VehicleModels");
        }

        public ActionResult New()
        {
            BaseModelVehicleService modelToAdd = new VehicleModelService();
            var viewModel = modelToAdd.New();

            return View("NewVehicleModelForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(VehicleModel vehiclemodel)
        {
            BaseModelVehicleService modelToSave = new VehicleModelService();
            modelToSave.Save(vehiclemodel);

            return RedirectToAction("Index", "VehicleModels");
        }

        public ActionResult Edit(int id)
        {
            BaseModelVehicleService modelToEdit = new VehicleModelService();
            var vehicleModelToEdit = modelToEdit.Edit(id);

            if (vehicleModelToEdit == null)
            {
                return HttpNotFound();
            }

            return View("EditVehicleModelForm", vehicleModelToEdit);
        }
    }

}