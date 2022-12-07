using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class StudentResponse
    {
        [Required(ErrorMessage ="İsminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Mail adresinizi giriniz")]
        [EmailAddress(ErrorMessage ="Mail adresinizi düzgün giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefonunuzu giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılım durumunuz nedir?")]
        public bool? Confirm { get; set; } //nullable
    }
}