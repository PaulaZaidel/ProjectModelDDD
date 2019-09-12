
using System.ComponentModel.DataAnnotations;

namespace ProjectModelDDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(250, ErrorMessage = "{0} characters max")]
        [MinLength(2, ErrorMessage = "{0} characters minimum")]
        public string Name { get; set; }

        [DataType(dataType: DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999")]
        [Required(ErrorMessage = "Required field")]
        public decimal Price { get; set; }

        [Display(Name = "Available?")]
        public bool Available { get; set; }
        public int ClientId { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}
