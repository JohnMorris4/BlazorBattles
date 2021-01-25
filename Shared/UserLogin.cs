using System.ComponentModel.DataAnnotations;

namespace BlazorBattles.Shared
{
    public class UserLogin : BaseModel
    {
        [Required] 
        public string UserName { get; set; }

        [Required] 
        public string Password { get; set; }
    }
}