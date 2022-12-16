using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pubs.Data;
using Pubs.Models;

namespace Pubs.Controllers
{
    public class AuthorController : Controller
    {
        private readonly PubsDbContext _context;
    public AuthorController(PubsDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult Index()
    {
        List<Author> Authors = _context.Authors.ToList();
        return View(Authors);
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        Author? Author = _context.Authors.SingleOrDefault(x => x.Id == id);

        if (Author == null) return RedirectToAction(nameof(Index));

        return View(Author);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Author Author)
    {
        if (!ModelState.IsValid) return View(Author);

        _context.Authors.Add(Author);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public ActionResult Delete(int id)
    {
        Author? Author = _context.Authors.SingleOrDefault(x => x.Id == id);

        if (Author == null) return RedirectToAction(nameof(Index));
        _context.Authors.Remove(Author);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Author? Author = _context.Authors.SingleOrDefault(x => x.Id == id);

        if (Author == null) return RedirectToAction(nameof(Index));
        return View(Author);
    }

    [HttpPost]
    public IActionResult Edit(Author Author)
    {
        if (!ModelState.IsValid) return View(Author);

        _context.Authors.Update(Author);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}
}
