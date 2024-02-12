using System.ComponentModel.DataAnnotations;

namespace ExSheet.Models
{
    public class ClientpMaster
    {

        [Key]
        public int ClientPId { get; set; }
        public int plant_no { get; set; }

        public string code { get; set; }

        public string address { get; set; }
    }
}
