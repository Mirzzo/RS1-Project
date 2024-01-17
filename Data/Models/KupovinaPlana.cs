using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class KupovinaPlana
    {
        [Key]
        public int KupovinaID {  get; set; }
        [ForeignKey(nameof(PlanID))]
        public int PlanID { get; set; }
        public PlanTreninga PlanTreninga { get; set; }
        [ForeignKey(nameof(KarticaID))]
        public int KarticaID { get; set; }
        public KreditnaKartica KreditnaKartica { get; set; }
        public DateTime VrijemeKupovine { get; set; }
    }
}
