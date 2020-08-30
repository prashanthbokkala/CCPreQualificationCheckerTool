using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace CCPreQualificationCheckerTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDetails>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/CustomerDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetails>> GetCustomerDetails(int id)
        {
            var customerDetails = await _context.Customers.FindAsync(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return customerDetails;
        }

        // PUT: api/CustomerDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerDetails(int id, CustomerDetails customerDetails)
        {
            if (id != customerDetails.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customerDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CustomerDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<CustomerDetails>> PostCustomerDetails(CustomerDetails customerDetails)
        //{
        //    _context.Customers.Add(customerDetails);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomerDetails", new { id = customerDetails.CustomerId }, customerDetails);
        //}

        [HttpPost]
        public async Task<IActionResult> PostCustomerDetails([FromBody] CustomerDetails customerDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Customers.Add(customerDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = customerDetails.CustomerId }, customerDetails);
        }


        // DELETE: api/CustomerDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerDetails>> DeleteCustomerDetails(int id)
        {
            var customerDetails = await _context.Customers.FindAsync(id);
            if (customerDetails == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customerDetails);
            await _context.SaveChangesAsync();

            return customerDetails;
        }

        private bool CustomerDetailsExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
