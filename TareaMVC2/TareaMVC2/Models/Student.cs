using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaMVC2.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "{0} cannot be longer than {1} characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "{0} cannot be longer than {1} characters")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}