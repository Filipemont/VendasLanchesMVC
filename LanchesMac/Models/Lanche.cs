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
        [StringLength(80, MinimumLength = 10, ErrorMessage ="O {0} deve ter no minimo {1} e no máximo {2} caracteres.")]
        public string LancheNome { get; set; }

        [Required(ErrorMessage = "A descrição curta do lanche deve ser feita")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage ="A descrição deve conter no mínimo {1} caracteres") ]
        [MaxLength(200, ErrorMessage = "A descrição deve conter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser feita")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição detalhada deve conter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição detalhada deve conter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "DPreço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre R$ 1,00 e R$ 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}caracteres.")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}caracteres.")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool isLanchePreferido { get; set; }

        [Display(Name = "Em Estoque?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId {  get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
