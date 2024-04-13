using System.ComponentModel.DataAnnotations;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
