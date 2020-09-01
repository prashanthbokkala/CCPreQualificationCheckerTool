using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using BusinessControl.BC;
using Utilities;

namespace CCPreQualificationCheckerTool.Controllers
{
    [Route("api/EligibilityCheck/")]
    public class EligibilityCheckController : Controller
    {
        private readonly AppDbContext _context;

        public EligibilityCheckController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EligibilityCheckController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EligibilityCheckController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EligibilityCheckController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EligibilityCheckController/Create
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

        //[Route("/saveEligibilityCheck")]
        [Route("saveEligibilityCheck")]
        [HttpPost]
        public async Task<CustomerCeditCardDetails> saveEligibilityCheck([FromBody] EligibilityCheck eligibilityCheckModel)
        {
            //int age = Common.GetAge(eligibilityCheckModel.DateOfBirth);
            //CreditCardDetails creditCardDetails = _context.CreditCards.Where(x => x.AgeLimit <= age
            //                       && x.MinAnnualIncome <= eligibilityCheckModel.AnnualIncome).OrderByDescending(o => o.MinAnnualIncome).FirstOrDefault();

            //CustomerDetails customerDetails = new CustomerDetails
            //{
            //    FirstName = eligibilityCheckModel.FirstName,
            //    LastName = eligibilityCheckModel.LastName,
            //    AnnualIncome = eligibilityCheckModel.AnnualIncome,
            //    DateOfBirth = eligibilityCheckModel.DateOfBirth,
            //    CardRefId = creditCardDetails.CardId,
            //    CreatedBy = eligibilityCheckModel.FirstName + eligibilityCheckModel.LastName,
            //    CreatedDate = DateTime.Now
            //};
            //var result = _context.Customers.Add(customerDetails);
            var result = EligibilityCheckBC.SaveEligibilityCheckBC(eligibilityCheckModel, _context);
            return result;
            //var result = _context.Customers.Add(customerDetails);// obj.InsertDepartment(departmentModel);
            //await _context.SaveChangesAsync();
            //if (result != null)
            //{
            //    return this.Ok("Customer Added Successfully");
            //}
            //else
            //{
            //    return this.BadRequest("Department Could not be added");
            //}
        }

        // GET: EligibilityCheckController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EligibilityCheckController/Edit/5
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

        // GET: EligibilityCheckController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EligibilityCheckController/Delete/5
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
