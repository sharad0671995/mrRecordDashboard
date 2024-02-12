using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExSheet.Models;

namespace ExSheet.Controllers
{
    public class LinemastersController : Controller
    {
        private readonly LevelDB _context;

        public LinemastersController(LevelDB context)
        {
            _context = context;
        }

        // GET: Linemasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.lineMasterss.ToListAsync());
        }

        // GET: Linemasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linemaster = await _context.lineMasterss
                .FirstOrDefaultAsync(m => m.LineId == id);
            if (linemaster == null)
            {
                return NotFound();
            }

            return View(linemaster);
        }

        // GET: Linemasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Linemasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LineId,code,Linename")] Linemaster linemaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linemaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linemaster);
        }

        // GET: Linemasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linemaster = await _context.lineMasterss.FindAsync(id);
            if (linemaster == null)
            {
                return NotFound();
            }
            return View(linemaster);
        }

        // POST: Linemasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LineId,code,Linename")] Linemaster linemaster)
        {
            if (id != linemaster.LineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linemaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinemasterExists(linemaster.LineId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(linemaster);
        }

        // GET: Linemasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linemaster = await _context.lineMasterss
                .FirstOrDefaultAsync(m => m.LineId == id);
            if (linemaster == null)
            {
                return NotFound();
            }

            return View(linemaster);
        }

        // POST: Linemasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var linemaster = await _context.lineMasterss.FindAsync(id);
            if (linemaster != null)
            {
                _context.lineMasterss.Remove(linemaster);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinemasterExists(int id)
        {
            return _context.lineMasterss.Any(e => e.LineId == id);
        }
    }
}
