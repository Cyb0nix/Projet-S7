using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaAPI.utils;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClerkController: ControllerBase
{
    private readonly dbContext _context;

    public ClerkController(dbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Clerk>>> GetClerks()
    {
        return await _context.Clerks.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Clerk>> GetClerk(int id)
    {
        var clerk = await _context.Clerks.FindAsync(id);

        if (clerk == null)
        {
            return NotFound();
        }

        return clerk;
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutClerk(int id, Clerk clerk)
    {
        if (id != clerk.ID)
        {
            return BadRequest();
        }

        _context.Entry(clerk).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ClerkExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    private bool ClerkExists(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<Clerk>> PostClerk(Clerk clerk)
    {
        _context.Clerks.Add(clerk);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetClerk", new { id = clerk.ID }, clerk);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClerk(int id)
    {
        var clerk = await _context.Clerks.FindAsync(id);
        if (clerk == null)
        {
            return NotFound();
        }

        _context.Clerks.Remove(clerk);
        await _context.SaveChangesAsync();

        return NoContent();
    }

   
}