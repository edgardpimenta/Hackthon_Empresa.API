namespace EmpresaAPI.Dtos
{
    public record EmpresaResponse(
            Guid Id,
            string Nome,
            string RazaoSocial,
            string CNPJ,
            string Telefone,
            string Endereco
        )
    {


    }
}
