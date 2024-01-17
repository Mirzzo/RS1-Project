using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayHard.Data.Models
{
    [PrimaryKey(nameof(PlanID), nameof(KorisnikID))]
    public class KorisnikPlan
    {
        public int PlanID { get; set; }

        public int KorisnikID { get; set; }
        public DateTime TrajanjePretplate {  get; set; } //ne mogu se sjetiti boljeg naziva
    }
}
