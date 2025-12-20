using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.Dtos
{
    public record EmpresaRequest
    {
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o telefone do fornecedor.")]
        public string? RazaoSocial { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Email do fornecedor.")]
        public string? CNPJ { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
    }

}
       
    

