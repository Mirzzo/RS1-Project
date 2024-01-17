using System.ComponentModel.DataAnnotations;

namespace StayHard.Data.Models
{
    public class TipTreninga
    {
        [Key]
        public int TipID { get; set; }
        public string Naziv {  get; set; }
    }
}
