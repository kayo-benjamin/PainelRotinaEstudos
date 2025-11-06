using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PainelRotinaEstudos.Data;
using PainelRotinaEstudos.Models;

namespace PainelRotinaEstudos.Pages.Activities
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Activity Activity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities.FirstOrDefaultAsync(m => m.Id == id);

            if (activity == null)
            {
                return NotFound();
            }

            Activity = activity;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities.FindAsync(id);

            if (activity != null)
            {
                Activity = activity;
                _context.Activities.Remove(Activity);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Atividade excluída com sucesso!";
            }

            return RedirectToPage("./Index");
        }
    }
}