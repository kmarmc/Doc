using Modelos;

namespace Controles;

public class ControlePedidos : ControleBase
{
  //----------------------------------------------------------------------------

  public ControlePedidos() : base()
  {
    NomeDaTabela = "Pedidos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idPedidos)
  {
    var collection = liteDB.GetCollection<Pedidos>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idPedidos);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pedidos>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pedidos>(NomeDaTabela);
    return new List<Pedidos>(tabela.FindAll().OrderBy(d => d.Sobrenome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPedidos)
  {
    var collection = liteDB.GetCollection<Pedidos>(NomeDaTabela);
    collection.Delete(idPedidos);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pedidos pedidos1)
  {
    var collection = liteDB.GetCollection<Pedidos>(NomeDaTabela);
    collection.Upsert(Pedidos);
  }

  //----------------------------------------------------------------------------
}

public class Pedidos
{
}