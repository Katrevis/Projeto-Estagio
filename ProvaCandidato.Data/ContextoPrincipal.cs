using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data
{
  public class ContextoPrincipal : DbContext
  {
        private const string CONNECTION_STRING = @"Server=localhost\SQLEXPRESS;Database=provacandidato;Trusted_Connection=True;";
    public ContextoPrincipal() : base(CONNECTION_STRING) { }

        public static string CONNECTION_STRING1 => CONNECTION_STRING;

        public static string CONNECTION_STRING2 => CONNECTION_STRING;

        public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
  }
}
