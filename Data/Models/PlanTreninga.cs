using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class PlanTreninga
    {
        [Key]
        public int PlanID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int TrenerID { get; set; }
        [ForeignKey(nameof(TrenerID))]
        public Trener Trener { get; set; }
        public byte[] Slika { get; set; }
        [ForeignKey(nameof(TipID))]
        public int TipID { get; set; }
        public TipTreninga TipTreninga { get;}
    }
}
