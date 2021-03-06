using System.ComponentModel.DataAnnotations;

namespace Souqly_API.Dtos.User
{
    public class UserForLogin
    {
        [StringLength(256), Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}