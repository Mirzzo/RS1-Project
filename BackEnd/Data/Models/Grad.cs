using System.ComponentModel.DataAnnotations;

namespace StayHard.Data.Models
{
    public class Grad
    {
        [Key]
        public int GradID { get; set; }
        public string NazivGrada { get; set; }
        public string Drzava { get; set; }
    }
}
