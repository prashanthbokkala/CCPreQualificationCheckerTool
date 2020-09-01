using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CCPreQualificationCheckerTool.Controllers
{
    [Route("api/CustomerDetails/")]
    public class CustomerDetailsController : Controller
    {
        // GET: CustomerDetailsController
        public ActionResult Index()
        {
            return View();
        }

        [Route("getCustomerDetails")]
        [HttpGet]
        public IEnumerable<CustomerDetails> GetCustomerDetails()
        {
            List<CustomerDetails> customerDetailsList = new List<CustomerDetails>();
            lstdept = obj.GetDepartmentDetails();
            return lstdept;
        }

        // GET: CustomerDetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
