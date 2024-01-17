using System.ComponentModel.DataAnnotations;

namespace StayHard.Data.Models
{
    public class Trener
    {
        [Key]
        public int TrenerID { get; set; }
        public string Certifikat { get; set; }
        public string Struka { get; set; }
    }
}
