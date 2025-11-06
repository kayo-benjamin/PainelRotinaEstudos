using System.ComponentModel.DataAnnotations;

namespace PainelRotinaEstudos.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A matéria é obrigatória")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "A matéria deve ter entre 2 e 100 caracteres")]
        [Display(Name = "Matéria")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "O dia da semana é obrigatório")]
        [StringLength(3)]
        [Display(Name = "Dia da Semana")]
        public string Day { get; set; } = string.Empty;

        [Required(ErrorMessage = "O horário é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Horário")]
        public string Time { get; set; } = string.Empty;

        [StringLength(500)]
        [Display(Name = "Descrição")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Data de Criação")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}