using LiteDB;
using Modelos;

namespace Controles;

public class ControleCortador : ControleBase
{
  //----------------------------------------------------------------------------

  public ControleCortador() : base()
  {
    NomeDaTabela = "Cortador";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCortador)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCortador);
  }

  //----------------------------------------------------------------------------

  public virtual List<Cortador>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cortador>(NomeDaTabela);
    return new List<Cortador>(tabela.FindAll().OrderBy(d => d.Sobrenome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCortador)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    collection.Delete(idCortador);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cortador cortador)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    collection.Upsert(Cortador);
  }

  //----------------------------------------------------------------------------
}