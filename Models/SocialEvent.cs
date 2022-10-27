using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PatoRestaurant.Models
{
    [Table("SocialEvent")]
    public class SocialEvent
    {
        [Key] //chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt16 Id { get; set; }
        
        [Display(Name= "Nome")]
        [Required(ErrorMessage = "Informe o {0}")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name= "Descrição")]
        [StringLength(2000, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres")]
        public string Description { get; set; }

        [Display(Name= "Data do Evento")]
        [Required(ErrorMessage = "Informe a {0}")]
        public string EventDate { get; set; }
        
        [Display(Name= "Imagem")]
        [StringLength(400)]
        public string Image { get; set; }
    }
}