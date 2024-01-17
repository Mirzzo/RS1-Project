using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    [PrimaryKey(nameof(KorisnikID), nameof(PlanID))]
    public class Recenzija
    {
        public int RecenzijaID { get; set; }
        public int KorisnikID { get; set; }
        //public int TrenerID { get; set; }
        public int PlanID { get; set; }
        public int Vrijednost {  get; set; }
        public string Opis {  get; set; }
        public DateTime Vrijeme { get; set; }
    }
}
