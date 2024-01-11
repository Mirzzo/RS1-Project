using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class SadrzajPlana
    {
        public int SadrzajID { get; set; }
        [ForeignKey(nameof(PlanID))]
        public int PlanID { get; set; }
        public PlanTreninga PlanTreninga { get; set; }
        public string Dan {  get; set; }
        public DateTime Vrijeme { get; set; }
        public string Opis { get; set; }

    }
}
