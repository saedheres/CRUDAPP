using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ListModel : PageModel
{
    // Conncet Database
    private readonly AppDbContext _context;
    public ListModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public List<Student> User {get;set;}

    public void OnGet()
    {
        User=_context.Students.ToList();
    }

    
}
