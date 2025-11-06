using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PainelRotinaEstudos.Data;
using PainelRotinaEstudos.Models;

namespace PainelRotinaEstudos.Pages.Activities
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Activity Activity { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Activity.CreatedAt = DateTime.Now;
            _context.Activities.Add(Activity);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Atividade adicionada com sucesso!";
            return RedirectToPage("./Index");
        }
    }
}