using ArmyTech.Data;
using ArmyTech.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArmyTech.Controllers
{
    public class CashiersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CashiersController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var applicationDbContext = _context.Cashier.Include(c => c.Branch);
            return View(applicationDbContext.ToList());
        }


        public IActionResult Details(int? id)
        {
            if (id == null || _context.Cashier == null)
            {
                return NotFound();
            }

            var cashier = _context.Cashier
                .Include(c => c.Branch)
                .FirstOrDefault(m => m.ID == id);
            if (cashier == null)
            {
                return NotFound();
            }

            return View(cashier);
        }
        public ActionResult New()
        {
            return View("Create");
        }
        public ActionResult Save(Cashier cashier)
        {
            if (cashier.ID == 0)
            {
                _context.Cashier.Add(cashier);
            }
            else
            {
                var cashierInDB = _context.Cashier.SingleOrDefault(c => c.ID == cashier.ID);
                cashierInDB.CashierName = cashier.CashierName;
                cashierInDB.BranchID = cashier.BranchID;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cashiers");
        }
        public ActionResult Edit(int Id)
        {
            var cashier = _context.Cashier.SingleOrDefault(c => c.ID == Id);

            if (cashier == null)
                return NotFound();

            return View("Create", cashier);
        }


        public IActionResult Delete(int id)
        {

            var cashier = _context.Cashier.Find(id);
            if (cashier != null)
            {
                _context.Cashier.Remove(cashier);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
