using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExSheet.Models
{
    public class ClientMaster
    {

        [Key]
        [Column(TypeName = "int")]
        public int ClientId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string code { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string logo { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public DateTime dateTime { get; set; }

        public ClientMaster()
        {
            // Set the current date and time when the object is created
            dateTime = DateTime.Now;
        }

    }
}
