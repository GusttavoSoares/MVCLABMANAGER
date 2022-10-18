using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller
{
    // coloca underline "_" quando o atributo é private 
    private readonly LabManagerContext _context;

    public ComputerController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Computers); // Computers é o DbSet configurado

    public IActionResult Show(int id) 
    {
        Computer? computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound(); // RedirectToAction("Index"); 
        }
    
        return View(computer);
        
    }
    
}