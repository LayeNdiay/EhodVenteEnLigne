using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class ProductViewModel
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom du produit est requis.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La description du produit est requise.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Les détails du produit sont requis.")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Le stock du produit est requis.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Le stock doit être un nombre entier positif.")]
        public string Stock { get; set; }

        [Required(ErrorMessage = "Le prix du produit est requis.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "PriceNotGreaterThanZero")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Le prix doit être un nombre décimal avec jusqu'à deux décimales.")]
        public string Price { get; set; }
    }
}
