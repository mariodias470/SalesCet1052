using System.ComponentModel.DataAnnotations;

namespace SalesCet1052.Web.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set;  }
                
        [Display(Name="País")]
        [MaxLength(50, ErrorMessage = "O campos {0} deve ter no máximo {1} caracteres ")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string?  Name { get; set; }
    }
}
