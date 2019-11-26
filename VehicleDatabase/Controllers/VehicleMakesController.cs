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
    public class VehicleMakesController : Controller
    {
        
        public ActionResult Index(string sortOrder, string searchString, int? page)
        {
            BaseMakeVehicleService makes = new VehicleMakeService();
            var makesToDisplay = makes.Index(sortOrder, searchString, page);

            return View(makesToDisplay.ToPagedList(page ?? 1, 5));
        }

        public ActionResult New()
        {
            return View("VehicleMakeForm");
        }

        [HttpPost]
        public ActionResult Save(VehicleMake vehiclemake)
        {
            BaseMakeVehicleService makeToSave = new VehicleMakeService();
            makeToSave.Save(vehiclemake);

            return RedirectToAction("Index", "VehicleMakes");
        }

        public ActionResult Edit(int id)
        {
            BaseMakeVehicleService makeToEdit = new VehicleMakeService();
            var vehicleMakeToEdit = makeToEdit.Edit(id);
            
            if (vehicleMakeToEdit == null)
            {
                return HttpNotFound();
            }

            return View("VehicleMakeForm", vehicleMakeToEdit);
        }

        public ActionResult Delete(int id)
        {
            BaseMakeVehicleService makeToDelete = new VehicleMakeService();
            makeToDelete.Delete(id);

            return RedirectToAction("Index", "VehicleMakes");
        }
    }
}