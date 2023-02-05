using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models
{
    public class Users
    {
        
        [Key]
     
        [Required]
        [Column(TypeName = "nvarchar(150)")]

        public int Student_Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
