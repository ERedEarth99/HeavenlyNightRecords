using HeavenlyNightRecords.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace HeavenlyNightRecords.Controllers
{
    public class AlbumController : Controller
    {
        private readonly RecordDbContext cxt;
        public AlbumController(RecordDbContext context)
        {
            cxt = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await cxt.Record.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Records records)
        {
            if (ModelState.IsValid)
            {
                cxt.Add(records);
                await cxt.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(records);
        }
        public async Task<IActionResult> Edit(int Id)
        {
            var record = await cxt.Record.FindAsync(Id);
            if (record == null)
            {
                return NotFound();
            }
            return View(record);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Records record)
        {
            if (Id != record.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    cxt.Update(record);
                    await cxt.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (RecordExist(record.Id))
                    {
                        return NotFound();
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(record);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var record = await cxt.Record.FindAsync(Id);
            if (record == null)
            {
                return NotFound();
            }
            return View(record);
        }

        [HttpPost]
        public  async Task<IActionResult> DeleteConfirmed(int Id) 
        {
            var record = await cxt.Record.FindAsync(Id);
            cxt.Record.Remove(record);
            await cxt.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }
        private bool RecordExist(int id)
        {
            return cxt.Record.Any(e => e.Id == id);
        }

    }
}