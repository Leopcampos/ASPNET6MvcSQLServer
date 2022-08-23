using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    [Table("DEPARTMENT")]
    public class Department
    {
        [Key]
        [Column("ID")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("NAME")]
        [Required(ErrorMessage = "O nome deve ser informado")]
        [Display(Name = "Nome")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Name { get; set; }
    }
}
