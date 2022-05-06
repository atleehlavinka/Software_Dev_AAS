using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskInventory.Models;
using Microsoft.EntityFrameworkCore;

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
            List<Disk> disks = context.Disks.OrderBy(d => d.DiskName).Include(g => g.Genre).Include(s => s.Status).Include(t => t.DiskType).ToList();
            return View(disks);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Genres = context.DiskGenres.OrderBy(g => g.Description).ToList();
            ViewBag.Statuses = context.DiskStatuses.OrderBy(s => s.Description).ToList();
            ViewBag.DiskTypes = context.DiskTypes.OrderBy(t => t.Description).ToList();
            return View("Edit", new Disk());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = context.DiskGenres.OrderBy(g => g.Description).ToList();
            ViewBag.Statuses = context.DiskStatuses.OrderBy(s => s.Description).ToList();
            ViewBag.DiskTypes = context.DiskTypes.OrderBy(t => t.Description).ToList();
            var disk = context.Disks.Find(id);
            return View(disk);
        }
        [HttpPost]
        public IActionResult Edit(Disk disk)
        {
            if (ModelState.IsValid)
            {
                if (disk.DiskId == 0)
                {
                    context.Database.ExecuteSqlRaw("execute sp_ins_disk @p0, @p1, @p2, @p3, @p4, @p5",
                        parameters: new[] { disk.DiskName.ToString(), disk.DiskArtist.ToString(), disk.ReleaseDate.ToString(), disk.StatusId.ToString(), disk.DiskTypeId.ToString(), disk.GenreId.ToString() });
                    TempData["message"] = "Disk added.";
                    //context.Disks.Add(disk);
                }
                else
                {
                    //    context.Disks.Update(disk);
                    context.Database.ExecuteSqlRaw("execute sp_upd_disk @p0, @p1, @p2, @p3, @p4, @p5, @p6",
                        parameters: new[] { disk.DiskId.ToString(), disk.DiskName.ToString(), disk.DiskArtist.ToString(), disk.ReleaseDate.ToString(), disk.StatusId.ToString(), disk.DiskTypeId.ToString(), disk.GenreId.ToString() });
                    TempData["message"] = "Disk updated.";
                    //context.SaveChanges();
                }
                return RedirectToAction("Index", "Disk");
            }
            else
            {
                ViewBag.Action = (disk.DiskId == 0) ? "Add" : "Edit";
                ViewBag.Genres = context.DiskGenres.OrderBy(g => g.Description).ToList();
                ViewBag.Statuses = context.DiskStatuses.OrderBy(s => s.Description).ToList();
                ViewBag.DiskTypes = context.DiskTypes.OrderBy(dt => dt.Description).ToList();
                return View(disk);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var disk = context.Disks.Find(id);
            return View(disk);
        }
        [HttpPost]
        public IActionResult Delete(Disk disk)
        {
            //context.Disks.Remove(disk);
            //context.SaveChanges();
            context.Database.ExecuteSqlRaw("execute  sp_del_disk @p0",
                parameters: new[] { disk.DiskId.ToString() });
            TempData["message"] = "Disk removed.";
            return RedirectToAction("Index", "Disk");
        }
    }
}
