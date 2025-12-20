namespace EmpresaAPI.Entities
{
    public class Empresa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
    }
}
