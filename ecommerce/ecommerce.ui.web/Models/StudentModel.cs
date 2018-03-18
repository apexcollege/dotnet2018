using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerce.ui.web.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Roll Number")]
        public int RollNo { get; set; }

        public string Grade { get; set; }

        [Display(Name = "Enrolled Date")]
        [DataType(DataType.Date)]
        public DateTime EnrolDate { get; set; }

        public bool Active { get; set; }

    }
}