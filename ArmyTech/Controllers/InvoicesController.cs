using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArmyTech.Data;
using ArmyTech.Data.Entities;
using ArmyTech.ViewModels;

namespace ArmyTech.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoicesController(ApplicationDbContext context)
        {
            _context = context;
        }

    
        public IActionResult Index()
        {
            var applicationDbContext = _context.InvoiceHeader.Include(i => i.Branch).Include(i => i.Cashier);
            return View( applicationDbContext.ToList());
        }

 
        public IActionResult Details(Int64 id)
        {
            if (id == null || _context.InvoiceHeader == null)
            {
                return NotFound();
            }

            var invoice = _context.InvoiceHeader
                .FirstOrDefault(m => m.ID == id);
            if (invoice == null)
            {
                return NotFound();
            }

            IQueryable<InvoiceDetails> details = _context.invoiceDetails.Where(c => c.InvoiceHeaderID == id);

            var totalPrice = 0.0;
            foreach (var invo in details)
            {
                totalPrice += invo.ItemPrice * invo.ItemCount;
            }

            InvoiceViewModel viewModel = new InvoiceViewModel()
            {
                invoiceHeader = invoice,
                invoiceDetails = details.ToList(),
                TotalPrice = totalPrice
            };

            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {

            var invoice = _context.InvoiceHeader.Find(id);
            if (invoice != null)
            {
                _context.InvoiceHeader.Remove(invoice);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
