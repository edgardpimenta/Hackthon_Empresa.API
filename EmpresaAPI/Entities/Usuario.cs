using Microsoft.AspNetCore.Http.Timeouts;

namespace EmpresaAPI.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string TipoEmpresa { get; set; } = string.Empty;
    }
}