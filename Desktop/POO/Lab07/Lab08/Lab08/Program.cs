using System;
using System.Collections.Generic;
using System.Linq;
using Lab08.Context;
using Lab08.Entities.Students;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos que implementen la interfaz IDisposable-> Destruye a 
            // los obj despues de su uso

            using (var db = new UcaContext())
            {
                db.Students.RemoveRange(db.Students);

                var stds = new List<Student>()
                {
                    new Student()
                    {
                        CardId = "00019618",
                        Career = "Ing. Informatica",
                        Name = "Walter",
                        LastName = "Morales"
                    },
                    new Student()
                    {
                        CardId = "00209020",
                        Career = "Ing. Informatica",
                        Name = "Daniel",
                        LastName = "Solis"
                    },
                    new Student()
                    {
                        CardId = "00176620",
                        Career = "Ing. Informatica",
                        Name = "Roberto",
                        LastName = "Alvarado"
                    },
                    new Student()
                    {
                        CardId = "00090220",
                        Career = "Ing. Informatica",
                        Name = "Lourdes",
                        LastName = "Jimenez"
                    },
                    new Student()
                    {
                        CardId = "00145620",
                        Career = "Ing. Informatica",
                        Name = "Raul",
                        LastName = "Gallardo"
                    },

                };
                
                stds.ForEach(st=>db.Add(st));

                db.SaveChanges();

                var savedStudent = db.Students
                    .OrderBy(st => st.Name)
                    .ToList();
                
                savedStudent.ForEach(st => Console.WriteLine(st.FullName));
            }
        }
    }
}