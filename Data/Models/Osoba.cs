using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class Osoba
    {
        [Key]
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja {  get; set; }
        public string BrojTelefona { get; set; }
        public int GradId { get; set; }
        [ForeignKey(nameof(GradId))]
        public Grad Grad { get; set; }
        public int KarticaID { get; set; }
        [ForeignKey(nameof(KarticaID))]
        public KreditnaKartica KreditnaKartica { get; set; }
        public byte[] Slika { get; set; }


    }
}
