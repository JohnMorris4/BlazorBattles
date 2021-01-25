using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBattles.Shared
{
    public class UserRegister : UserLogin
    {
        [Required] 
        [EmailAddress] 
        public string EmailAddress { get; set; }

        public string Bio { get; set; }

        [Compare("Password")] 
        public string ConfirmPassword { get; set; }

        public string StartUnitId { get; set; } = "1";

        [Range(0, 1000, ErrorMessage = "You must be between 0 and 1000")]
        public int Bananas { get; set; } = 1000;

        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play")]
        public bool IsConfirmed { get; set; } = true;
    }
}