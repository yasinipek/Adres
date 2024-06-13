using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Database.Migrate();

                var adresim = Adres.AdresGetir();
                context.Iller.AddRange(adresim);
                context.SaveChanges();
            }
        }
    }
}
