using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudMVC.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="City required")]

        public string City { get; set; }

        [Required(ErrorMessage ="Address required")]

        public string Address { get; set; }



    }
}