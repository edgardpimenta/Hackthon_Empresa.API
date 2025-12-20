using EmpresaAPI.Dtos;
using EmpresaAPI.Entities;
using EmpresaAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
            
            [HttpPost]
        public IActionResult PostEmpresa(EmpresaRequest request)
        {
            var empresa = new Empresa
            {   
                Id = Guid.NewGuid(),
                Nome = request.Nome!,
                RazaoSocial = request.RazaoSocial!,
                CNPJ = request.CNPJ!,
                Telefone = request.Telefone!,
                Endereco = request.Endereco!
            };
            var empresaRepository = new EmpresaRepository();
            empresaRepository.Add(empresa);

            var response = new
            {
                Id = empresa.Id,
                Nome = empresa.Nome,
                RazaoSocial = empresa.RazaoSocial,
                CNPJ = empresa.CNPJ,
                Telefone = empresa.Telefone,
                Endereco = empresa.Endereco
            };
            return Ok(response);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var repository = new EmpresaRepository();
            var empresa = repository.ObterTodos();
            return Ok(empresa);
            

        }

        [HttpPut]
        public IActionResult Atualizar([FromBody] Empresa request) 
        {
            var empresa = new Empresa();
            {
                empresa.Id = request.Id;
                empresa.CNPJ = request.CNPJ;
                empresa.Endereco = request.Endereco;
                empresa.Nome = request.Nome;
                empresa.RazaoSocial = request.RazaoSocial;
                empresa.Telefone = request.Telefone;
            }
            ;
         var empresaRepository = new EmpresaRepository();

            empresaRepository.Atualizar(empresa);
            return Ok("Empresa atualizada");

        }
        [HttpDelete]
        public IActionResult DeleteEmpresa(Guid Id)
        {
            var empresaRepository = new EmpresaRepository();

            var empresa = empresaRepository.GetById(Id);

            if (empresa == null)
            {
                return NotFound("Empresa não encontrada");
            }
            else {
                empresaRepository.Delete(empresa);
            }

            return Ok("Empresa deletada");
            


        }
    }
}
    
