using ExSheet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace ExSheet.Controllers
{
    public class ClientMasterController : Controller
    {
        private readonly LevelDB _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ClientMasterController(LevelDB context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Pets
        public async Task<IActionResult> Index()
        {

            return View(await _context.ClientMasterss.ToListAsync());
        }

        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.ClientMasterss
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public IActionResult AddOrEdit(int Id = 0)
        {
            if (Id == 0)
                return View(new ClientMaster());
            else
                return View(_context.ClientMasterss.Find(Id));
        }

        // POST: Pets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("ClientId,code,name,logo,ImageFile,dateTime")] ClientMaster clientMaster)
        {
            if (ModelState.IsValid)
            {

                //Save image to wwwroot/image
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(clientMaster.ImageFile.FileName);
                string extension = Path.GetExtension(clientMaster.ImageFile.FileName);
                clientMaster.logo = fileName = DateTime.Now.ToString("yyMMddhhmmss") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await clientMaster.ImageFile.CopyToAsync(fileStream);
                }

                if (clientMaster.ClientId == 0)
                {

                    _context.Add(clientMaster);
                }
                else
                {
                    _context.Update(clientMaster);

                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientMaster);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var clientMaster = await _context.ClientMasterss.FindAsync(id);
            if (clientMaster == null)
            {
                return NotFound();
            }
            return View(clientMaster);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientId,code,name,logo,ImageFile,dateTime")] ClientMaster clientMasters)
        {
            if (id != clientMasters.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Save image to wwwroot/image
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(clientMasters.ImageFile.FileName);
                    string extension = Path.GetExtension(clientMasters.ImageFile.FileName);
                    clientMasters.logo = fileName = DateTime.Now.ToString("yyMMddhhmmss") + extension;
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await clientMasters.ImageFile.CopyToAsync(fileStream);
                    }
                    _context.Update(clientMasters);
                    await _context.SaveChangesAsync();







                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientMasterExists(clientMasters.ClientId))
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

             return View(clientMasters);
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.ClientMasterss
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            

            var ClientMaster = await _context.ClientMasterss.FindAsync(id);
            if (ClientMaster != null)
            {
                _context.ClientMasterss.Remove(ClientMaster);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientMasterExists(int id)
        {
            return _context.ClientMasterss.Any(e => e.ClientId == id);
        }
    }
}
