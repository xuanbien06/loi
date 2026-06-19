
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lesson3_ORM_BookManagement.Models;
using Lesson3_CNLTWeb.Data;

public class RoomTypesController : Controller
{
    private readonly AppDbContext _context;

    public RoomTypesController(AppDbContext context)
    {
        _context = context;
    }

    // GET: ROOMTYPE_BIT240041S
    public async Task<IActionResult> Index()    
    {
        return View(await _context.RoomTypes.ToListAsync());
    }

    // GET: ROOMTYPE_BIT240041S/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var roomtype_bit240041 = await _context.RoomTypes
            .FirstOrDefaultAsync(m => m.Id == id);
        if (roomtype_bit240041 == null)
        {
            return NotFound();
        }

        return View(roomtype_bit240041);
    }

    // GET: ROOMTYPE_BIT240041S/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ROOMTYPE_BIT240041S/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Rooms")] RoomType_BIT240041 roomtype_bit240041)
    {
        if (ModelState.IsValid)
        {
            _context.Add(roomtype_bit240041);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(roomtype_bit240041);
    }

    // GET: ROOMTYPE_BIT240041S/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var roomtype_bit240041 = await _context.RoomTypes.FindAsync(id);
        if (roomtype_bit240041 == null)
        {
            return NotFound();
        }
        return View(roomtype_bit240041);
    }

    // POST: ROOMTYPE_BIT240041S/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Rooms")] RoomType_BIT240041 roomtype_bit240041)
    {
        if (id != roomtype_bit240041.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(roomtype_bit240041);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomType_BIT240041Exists(roomtype_bit240041.Id))
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
        return View(roomtype_bit240041);
    }

    // GET: ROOMTYPE_BIT240041S/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var roomtype_bit240041 = await _context.RoomTypes
            .FirstOrDefaultAsync(m => m.Id == id);
        if (roomtype_bit240041 == null)
        {
            return NotFound();
        }

        return View(roomtype_bit240041);
    }

    // POST: ROOMTYPE_BIT240041S/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var roomtype_bit240041 = await _context.RoomTypes.FindAsync(id);
        if (roomtype_bit240041 != null)
        {
            _context.RoomTypes.Remove(roomtype_bit240041);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool RoomType_BIT240041Exists(int? id)
    {
        return _context.RoomTypes.Any(e => e.Id == id);
    }
}
