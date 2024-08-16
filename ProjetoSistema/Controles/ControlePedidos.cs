using LiteDB;
using Modelos;

namespace Controles;

public class ControlePedido : ControleBase
{
  //----------------------------------------------------------------------------

  public ControlePedido() : base()
  {
    NomeDaTabela = "Pedido";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pedido>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return new List<Pedido>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Delete(idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pedido pedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Upsert(pedido);
  }

  //----------------------------------------------------------------------------
}

