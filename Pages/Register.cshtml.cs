using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegisterModel: PageModel
{
    private readonly AppDbContext _context;
    public RegisterModel(AppDbContext context)
    {
        _context=context;
    }
    [BindProperty]
    public int ID { get; set; }
    [BindProperty]
    public string Name { get; set; }
    [BindProperty]
    public int Age { get; set; }

    public IActionResult OnPost()
    {
         var student = new Student{
            Name = Name,
            Age = Age
        };
        _context.Students.Add(student);
        _context.SaveChanges();
        return RedirectToPage("List");
      
     
    }
}