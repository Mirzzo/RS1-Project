using StayHard.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Modules.ViewModels
{
    public class OsobaRegistracijaVM
    {
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public int GradID { get; set; }
        public int KarticaID { get; set; }
       // public byte[] Slika { get; set; }
    }
}
