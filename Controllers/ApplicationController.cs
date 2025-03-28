using Microsoft.AspNetCore.Mvc;
using TourASBM.Data;
using TourASBM.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TourASBM.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApplicationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Application/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Application/Create
        [HttpPost]
        public async Task<IActionResult> Create(ApplicationForm model, IFormFile DocumentFile)
        {
            if (ModelState.IsValid)
            {
                if (DocumentFile != null)
                {
                    string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                    // Ensure the folder exists
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(DocumentFile.FileName);
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await DocumentFile.CopyToAsync(fileStream);
                    }

                    model.DocumentPath = "/uploads/" + uniqueFileName; // Save relative path
                }

                _context.TourASBM.Models.ApplicationForm.Add(model);
                ;  // Ensure correct DbSet
                await _context.SaveChangesAsync();
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
