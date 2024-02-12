using System.ComponentModel.DataAnnotations;

namespace ExSheet.Models
{
    public class Linemaster
    {


        [Key]
        public int LineId { get; set; }
        public string code { get; set; }
        public string Linename { get; set; }
    }
}
