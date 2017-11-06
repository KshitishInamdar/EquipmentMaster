using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EquipmentMaster.Models;

namespace EquipmentMaster.Controllers
{
    public class EquipmentMasterController : Controller
    {

        DBConnect.DBConnect dbConnect = null;

        public EquipmentMasterController()
        {
            dbConnect = new DBConnect.DBConnect();
        }

        //
        // GET: /EquipmentMaster/
        public ActionResult Index()
        {
            return RedirectToAction("ViewEquipment");
        }

        public ActionResult Add()
        {
            ViewBag.Title = "Add Equipment";
            ViewBag.Description = "Add a new Equipment";
            ViewBag.ButtonText = "Add";

            return View("AddUpdate");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Edit Equipment";
            ViewBag.Description = "Edit the exisitng Equipment";
            ViewBag.ButtonText = "Update";

            var equipment = dbConnect.GetEquipment(id);

            return View("AddUpdate", Utility.Utility.ToEquipmentViewModel(equipment));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Add(EquipmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                dbConnect.Add(model);
            }

            return RedirectToAction("ViewEquipment");
        }

        public ActionResult View(int id)
        {
            var equipment = dbConnect.GetEquipment(id);

            return View(Utility.Utility.ToEquipmentViewModel(equipment));
        }

        public ActionResult ViewEquipment()
        {
            var model = new AllEquipmentViewModel();
            model.Equipments = dbConnect.GetAllEquipment();
            return View(model);
        }

        public ActionResult Remove(int id)
        {
            ViewBag.Title = "Remove Equipment";
            dbConnect.Remove(id);
            return View();
        }
	}
}