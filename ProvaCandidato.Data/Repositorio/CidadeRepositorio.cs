using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Repositorio
{
    public class CidadeRepositorio
    {
        private readonly ContextoPrincipal _contexto;

        //construtor
        public CidadeRepositorio()
        {

            _contexto = new ContextoPrincipal();
        }

        //banco de dados consulta
        public IList<Cidade> ListarCidades()
        {
          return _contexto.Set<Cidade>().ToList();
        }

        //buscar cidade
        public Cidade BuscarCidade(int codigo_cidade)
        {
            return _contexto.Set<Cidade>().Where(X => X.Codigo == codigo_cidade).First();
        }
        //incluir cidade
        public void IncluirCidade(Cidade cidade)
        {
           _contexto.Entry<Cidade>(cidade).State = System.Data.Entity.EntityState.Added;
           _contexto.SaveChanges();
        }

        //alterar cidade
        public void AlterarCidade(Cidade cidade)
        {
            _contexto.Entry<Cidade>(cidade).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }


        //deletar cidade
        public void DeletarCidade(int codigo_cidade)
        {
          var cidade = BuscarCidade(codigo_cidade);

            _contexto.Entry<Cidade>(cidade).State = System.Data.Entity.EntityState.Deleted;
            _contexto.SaveChanges();
        }
    }
}
