using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public int OsobaID { get; set; }
        [ForeignKey(nameof(OsobaID))]
        public Osoba Osoba { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password {  get; set; }
        public string Email { get; set; }
        public int BMI { get; set; }
        public bool isVIP { get; set; }
    }
}
