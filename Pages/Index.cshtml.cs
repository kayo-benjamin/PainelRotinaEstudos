using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PainelRotinaEstudos.Data; // Precisa do DbContext
using PainelRotinaEstudos.Models; // Precisa do Model Activity

namespace PainelRotinaEstudos.Pages
{
    // Este é o Model para a Pages/Index.cshtml
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // Construtor injeta o DbContext
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Propriedade para guardar a lista de atividades para o .cshtml
        public IList<Activity> Activities { get; set; } = default!;

        // Método que busca os dados quando a página carrega
        public async Task OnGetAsync()
        {
            Activities = await _context.Activities
                .OrderBy(a => a.Day)
                .ThenBy(a => a.Time)
                .ToListAsync();
        }
    }
}