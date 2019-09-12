
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectModelDDD.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(150, ErrorMessage = "{0} characters max")]
        [MinLength(2, ErrorMessage = "{0} characters minimum")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(150, ErrorMessage = "{0} characters max")]
        [MinLength(2, ErrorMessage = "{0} characters minimum")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(100, ErrorMessage = "{0} characters max")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Created { get; set; }

        public bool Active { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}
