using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamPractice.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string LoginName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Password")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Password { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter FullName")]
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string FullName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Email")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Please Enter Email")]
        public int CityId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Phone")]
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public IEnumerable<SelectListItem> Cities { get; set; }
        
    }
}