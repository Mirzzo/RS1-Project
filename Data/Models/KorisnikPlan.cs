using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    public class KorisnikPlan
    {
        [Key, Column(Order =0)]
        public int PlanID { get; set; }
        [Key, Column(Order = 1)]

        public int KorisnikID { get; set; }
        public DateTime TrajanjePretplate {  get; set; } //ne mogu se sjetiti boljeg naziva
    }
}
