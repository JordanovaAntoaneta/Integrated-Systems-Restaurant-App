using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ERestaurant.Domain.Domain;
using ERestaurant.Repository;
using ERestaurant.Service;
using ERestaurant.Service.Implementation;

namespace ERestaurant.Web.Controllers
{
    public class AlbumsController : Controller
    {

            private readonly AlbumService _albumService;

            public AlbumsController(AlbumService albumService)
            {
                _albumService = albumService;
            }
            public async Task<IActionResult> Index()
            {
                var albums = await _albumService.GetAllAlbumsAsync();

                return View(albums);
            }

        //private readonly ApplicationDbContext _context;

        //public AlbumsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: Albums
        //public async Task<IActionResult> Index()
        //{
        //    HttpClient client = new HttpClient();
        //    string URL = "https://dinemaster.azurewebsites.net/api/DeliveryPerson/GetDeliveryPeople";

        //    HttpResponseMessage response = client.GetAsync(URL).Result;

        //    var data = response.Content.ReadAsAsync<List<Album>().Result;

        //    return View(data);
        //}

        //// GET: Albums/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var album = await _context.Albums
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (album == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(album);
        //}

        //// GET: Albums/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Albums/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Title,CoverImageUrl,Description,ReleaseDate,Tags,Type,Id")] Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        album.Id = Guid.NewGuid();
        //        _context.Add(album);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(album);
        //}

        //// GET: Albums/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var album = await _context.Albums.FindAsync(id);
        //    if (album == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(album);
        //}

        //// POST: Albums/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Title,CoverImageUrl,Description,ReleaseDate,Tags,Type,Id")] Album album)
        //{
        //    if (id != album.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(album);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AlbumExists(album.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(album);
        //}

        //// GET: Albums/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var album = await _context.Albums
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (album == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(album);
        //}

        //// POST: Albums/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var album = await _context.Albums.FindAsync(id);
        //    if (album != null)
        //    {
        //        _context.Albums.Remove(album);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AlbumExists(Guid id)
        //{
        //    return _context.Albums.Any(e => e.Id == id);
        //}
    }
}
