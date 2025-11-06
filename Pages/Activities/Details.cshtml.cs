using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PainelRotinaEstudos.Data;
using PainelRotinaEstudos.Models;

namespace PainelRotinaEstudos.Pages.Activities
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

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

        // Helper para mostrar o nome completo do dia
        public string GetDayFullName(string day)
        {
            return day switch
            {
                "SEG" => "Segunda-feira",
                "TER" => "Terça-feira",
                "QUA" => "Quarta-feira",
                "QUI" => "Quinta-feira",
                "SEX" => "Sexta-feira",
                "SAB" => "Sábado",
                "DOM" => "Domingo",
                _ => day
            };
        }
    }
}