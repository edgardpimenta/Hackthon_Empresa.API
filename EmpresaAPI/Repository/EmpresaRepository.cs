using EmpresaAPI.Context;
using EmpresaAPI.Entities;
using System.Runtime.InteropServices.Marshalling;

namespace EmpresaAPI.Repository
{
    public class EmpresaRepository
    {
        public void Add(Empresa empresa)
        {
            using (var context = new DataContext())
            {
                context.Add(empresa);
                context.SaveChanges();
            }
               
        }
        public List<Empresa> ObterTodos()
        {
            using var context = new DataContext();
            return context.Set<Empresa>().ToList();
        }
        public void Atualizar(Empresa empresa)
        {
            using var context = new DataContext();
            context.Update(empresa);
            context.SaveChanges();

        }
        public void Delete(Empresa empresa)
        {
            using (var context = new Context.DataContext())
            {
                context.Remove(empresa);
                context.SaveChanges();
            }
        }

        public Empresa? GetById(Guid id)
        {
            using (var context = new Context.DataContext())
            {
                return context.Set<Empresa>().FirstOrDefault(f => f.Id == id);
            }
        }
    }

    }
