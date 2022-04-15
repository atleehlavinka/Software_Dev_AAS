using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    public class DiskController : Controller
    {
        private disk_inventoryahContext context { get; set; }
        public DiskController(disk_inventoryahContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            List<Disk> disk = context.Disks.OrderBy(b => b.DiskArtist).ThenBy(b => b.DiskName).ToList();
            return View(disk);
        }
    }
}
