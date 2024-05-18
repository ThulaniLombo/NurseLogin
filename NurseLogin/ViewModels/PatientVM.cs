using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using NurseLogin.Models;

namespace NurseLogin.ViewModels
{
    public class PatientVM 
    {
   
        [Required]
        public string? PatientName { get; set; }
        
        [Required]
        public string? PatientSurname { get; set; }

        public string PatientFulName =>$"{PatientName} {PatientSurname}";

        [Required]
        public string? IDNumber { get; set; }
    }
}
