using System.ComponentModel.DataAnnotations;

namespace StayHard.Data.Models
{
    public class KreditnaKartica
    {
        [Key]
        public int KarticaID { get; set; }
        public string BrojKartice { get; set; }
        public DateTime DatumIsteka { get; set; }
        public string SigurnosniBroj { get; set; }
    }
}
