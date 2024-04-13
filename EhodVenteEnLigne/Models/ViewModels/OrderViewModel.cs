using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class OrderViewModel
    {
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "La ville est requise.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Le code postal est requis.")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Le pays est requis.")]
        public string Country { get; set; }

        [BindNever]
        public DateTime Date { get; set; }
    }
}
