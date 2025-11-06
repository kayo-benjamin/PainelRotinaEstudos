using Microsoft.EntityFrameworkCore;
using PainelRotinaEstudos.Models;

namespace PainelRotinaEstudos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dados iniciais para testes
            modelBuilder.Entity<Activity>().HasData(
                new Activity
                {
                    Id = 1,
                    Subject = "MAT23",
                    Day = "SEG",
                    Time = "3:30",
                    Description = "Matemática Algebra Linear",
                    CreatedAt = DateTime.Now
                },
                new Activity
                {
                    Id = 2,
                    Subject = "PDR15a",
                    Day = "SEG",
                    Time = "PDR15a",
                    Description = "Programação Desenvolvimento Web",
                    CreatedAt = DateTime.Now
                },
                new Activity
                {
                    Id = 3,
                    Subject = "FIS101",
                    Day = "TER",
                    Time = "2:00",
                    Description = "Fisica Mecânica",
                    CreatedAt = DateTime.Now
                },
                new Activity
                {
                    Id = 4,
                    Subject = "ENG204",
                    Day = "QUA",
                    Time = "4:15",
                    Description = "Engenharia de Software",
                    CreatedAt = DateTime.Now
                },
                new Activity
                {
                    Id = 5,
                    Subject = "ALG301",
                    Day = "QUI",
                    Time = "1:30",
                    Description = "Algoritmos Avançados",
                    CreatedAt = DateTime.Now
                },
                new Activity
                {
                    Id = 6,
                    Subject = "BD202",
                    Day = "SEX",
                    Time = "3:00",
                    Description = "Banco de Dados",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}