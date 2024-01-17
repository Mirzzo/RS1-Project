using Microsoft.EntityFrameworkCore;
using StayHard.Data.Models;

namespace StayHard.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Trener> Trener { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<PlanTreninga> PlanTreninga {  get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<KorisnikPlan> KorisnikPlan { get; set; }
        public DbSet<KreditnaKartica> KreditnaKartica { get; set; }
        public DbSet<KupovinaPlana> KupovinaPlana { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<SadrzajPlana> SadrzajPlana { get; set; }
        public DbSet<TipTreninga> TipTreninga { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

    }
}
