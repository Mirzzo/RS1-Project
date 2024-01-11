using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class Recenzija
    {
        public int RecenzijaID { get; set; }
        [Key, Column(Order =0)]
        public int KorisnikID { get; set; }
        //public int TrenerID { get; set; }
        [Key, Column(Order =1)]
        public int PlanID { get; set; }
        public int Vrijednost {  get; set; }
        public string Opis {  get; set; }
        public DateTime Vrijeme { get; set; }
    }
}
