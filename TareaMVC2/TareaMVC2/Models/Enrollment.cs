using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaMVC2.Models
{
    public class Enrollment
    {
        public enum ClassGrades
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            F = 5
        }
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No Grade")]
        public ClassGrades Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}