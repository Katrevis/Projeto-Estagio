using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Repositorio
{
    class ClienteRepositorio
    {
        
        private readonly ContextoPrincipal _contexto;

        //construtor
        public ClienteRepositorio()
        {

            _contexto = new ContextoPrincipal();
        }
        public IList<Cliente> ListarCliente()
        {
            return _contexto.Set<Cliente>().ToList();
        }
        //buscar cliente
        public Cliente BuscarCliente(int codigo_cliente)
        {
            return _contexto.Set<Cliente>().Where(X => X.Codigo == codigo_cliente).First();
        }
        //incluir cliente
        public void IncluirCliente(Cliente cliente)
        {
            _contexto.Entry<Cliente>(cliente).State = System.Data.Entity.EntityState.Added;
            _contexto.SaveChanges();
        }

        //alterar cliente
        public void AlterarCliente(Cliente cliente)
        {
            _contexto.Entry<Cliente>(cliente).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }


        //deletar cliente
        public void DeletarCliente(int codigo_cliente)
        {
            var cliente = BuscarCliente(codigo_cliente);

            _contexto.Entry<Cliente>(cliente).State = System.Data.Entity.EntityState.Deleted;
            _contexto.SaveChanges();
        }
    }
}
