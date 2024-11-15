using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            List<Parent> parents = new List<Parent>
            {
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Okos",
                    LastName="Olívia",
                    Address="Petőfi Sándor sgrt.10.",
                    IsWoman=true,
                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Buta",
                    LastName="Balázs",
                    Address="Boldogasszony sgrt.20.",
                    IsWoman=false,
                }
            };

            List<Uthiba> uthibak = new List<Uthiba>
            {
                new Uthiba
                {
                    Id=Guid.NewGuid(),
                    Leiras = "Kátyú",
                    Address="Petőfi Sándor sgrt. 10.",
                    IsDone=true
                },
                new Uthiba
                {
                    Id=Guid.NewGuid(),
                    Leiras = "Benőtt tábla",
                    Address="Mars tér 10.",
                    IsDone=false
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Parent>().HasData(parents);
            modelBuilder.Entity<Uthiba>().HasData(uthibak);
        }
    }
}
