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
    public class ClientpMastersController : Controller
    {
        private readonly LevelDB _context;

        public ClientpMastersController(LevelDB context)
        {
            _context = context;
        }

        // GET: ClientpMasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientpmasterss.ToListAsync());
        }

        // GET: ClientpMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientpMaster = await _context.Clientpmasterss
                .FirstOrDefaultAsync(m => m.ClientPId == id);
            if (clientpMaster == null)
            {
                return NotFound();
            }

            return View(clientpMaster);
        }

        // GET: ClientpMasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientpMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientPId,plant_no,code,address")] ClientpMaster clientpMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientpMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientpMaster);
        }

        // GET: ClientpMasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientpMaster = await _context.Clientpmasterss.FindAsync(id);
            if (clientpMaster == null)
            {
                return NotFound();
            }
            return View(clientpMaster);
        }

        // POST: ClientpMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientPId,plant_no,code,address")] ClientpMaster clientpMaster)
        {
            if (id != clientpMaster.ClientPId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientpMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientpMasterExists(clientpMaster.ClientPId))
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
            return View(clientpMaster);
        }

        // GET: ClientpMasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientpMaster = await _context.Clientpmasterss
                .FirstOrDefaultAsync(m => m.ClientPId == id);
            if (clientpMaster == null)
            {
                return NotFound();
            }

            return View(clientpMaster);
        }

        // POST: ClientpMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientpMaster = await _context.Clientpmasterss.FindAsync(id);
            if (clientpMaster != null)
            {
                _context.Clientpmasterss.Remove(clientpMaster);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientpMasterExists(int id)
        {
            return _context.Clientpmasterss.Any(e => e.ClientPId == id);
        }
    }
}
