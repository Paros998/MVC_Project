using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Romantic Comedy",
                            Rating ="R",
                            Price = 7.99M
                        },

                        new Movie
                        {
                            Title = "Ghostbusters ",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Rating = "12+",
                            Price = 8.99M
                        },

                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Rating = "12+",
                            Price = 9.99M
                        },

                        new Movie
                        {
                            Title = "Rio Bravo",
                            ReleaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Rating = "R",
                            Price = 3.99M
                        }
                    );
                }

                if(!context.Student.Any())
                {
                    context.Student.AddRange(
                        new Student{
                            StudentName = "Richard",
                            StudentSurname = "Bravo",
                            Age = 21,
                            Year = 3,
                            Semester = 1,
                            JoinTime = "01.01.2018",
                            University = "Politechnika Świętokrzyska w Kielcach"
                        }

                    );
                }
                if(!context.Raport.Any()){

                    context.Raport.AddRange(
                        new Raport{
                            NrRaportu = 1,
                            DataRaportu = DateTime.Parse("2021-07-26"),

                            Odczyt1 = 18.676 ,  
                            Odczyt2 = 18.702 ,
                            Odczyt3 = 18.697 ,

                            TypOdczytu = "Badanie Gestości Odlewu",

                            NazwaZakladu = "FM-Gorzyce",
                            Produkt = "Tłok AL-15",
                            Seria = "S21/07/26"
                        },
                        new Raport{
                            NrRaportu = 2,
                            DataRaportu = DateTime.Parse("2021-07-27"),

                            Odczyt1 = 0.0002 ,  
                            Odczyt2 = 0.0007 ,
                            Odczyt3 = 0.0009 ,

                            TypOdczytu = "Kontrola odstępstwa poziomego",

                            NazwaZakladu = "FM-Gorzyce",
                            Produkt = "Tłok AL-15",
                            Seria = "S21/07/26"
                        },
                        new Raport{
                            NrRaportu = 3,
                            DataRaportu = DateTime.Parse("2021-07-28"),

                            Odczyt1 = 0.007 ,  
                            Odczyt2 = 0.012 ,
                            Odczyt3 = 0.009 ,

                            TypOdczytu = "Test oporu ścieralności",

                            NazwaZakladu = "FM-Gorzyce",
                            Produkt = "Tłok AL-15",
                            Seria = "S21/07/26"
                        }

                    );
                }
                if(!context.Produkt.Any()){
                    context.AddRange(
                        new Produkt{
                            nazwa = "Tłok AL-15",
                            typBadania = "Test oporu ścieralności",
                            normaLow = 0.007,
                            normaHigh = 0.014
                        },
                        new Produkt{
                            nazwa = "Tłok AL-15",
                            typBadania = "Kontrola odstępstwa poziomego",
                            normaLow = 0.000,
                            normaHigh = 0.008
                        },
                        new Produkt{
                            nazwa = "Tłok AL-15",
                            typBadania = "Badanie Gestości Odlewu",
                            normaLow = 18.650,
                            normaHigh = 18.700
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}