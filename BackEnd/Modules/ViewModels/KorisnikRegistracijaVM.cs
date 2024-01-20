using StayHard.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Modules.ViewModels
{
    public class KorisnikRegistracijaVM
    {
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int BMI { get; set; }
    }
}
