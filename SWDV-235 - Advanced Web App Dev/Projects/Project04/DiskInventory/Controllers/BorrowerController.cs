using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    
    public class BorrowerController : Controller
    {
        private disk_inventoryahContext context { get; set; }
        public BorrowerController(disk_inventoryahContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            List<DiskBorrower> borrowers = context.DiskBorrowers.OrderBy(b => b.Lname).ThenBy(b => b.Fname).ToList();
            return View(borrowers);
        }
    }
}
