using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display (Name= "Nome do Lanche")]
        public string LancheNome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser feita")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage ="A descrição deve conter no mínimo {1} caracteres") ]
        [MaxLength(200, ErrorMessage = "A descrição deve conter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool isLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoriaId {  get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
