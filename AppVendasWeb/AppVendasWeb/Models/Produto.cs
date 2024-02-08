using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Produto
    {

        public Guid ProdutoId { get; set; }
        [Required(ErrorMessage = "O campo Preço é Obrigatório")]
        [Display(Name = "Nome do Produto")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Descrição deve ter entre 3 e 100 caracteres")]

        public string ProdutoDescricao { get; set; }
        [Required(ErrorMessage = "O campo Preço e obrigatorio!")]
        [Display(Name = "Preço")]
        public decimal PrecoProduto { get; set; }
        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
