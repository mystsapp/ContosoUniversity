using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key] // There's a one-to-zero-or-one relationship between the Instructor and the OfficeAssignment entities
        public int InstructorID { get; set; } // name doesn't follow the ID or classnameID & used to identify it as the key

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}