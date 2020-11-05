using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TutorialsTeacher.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage ="The student name field is empty")]
        public string StudentName { get; set; }
        [Range(17,25)]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}