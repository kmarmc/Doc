using LiteDB;
using Modelos;

namespace Controles;

public class ControleMateriaPrima : ControleBase
{
  //----------------------------------------------------------------------------

  public ControleMateriaPrima() : base()
  {
    NomeDaTabela = "MateriaPrima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMateriaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual List<MateriaPrima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    return new List<MateriaPrima>(tabela.FindAll().OrderBy(d => d.Sobrenome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Delete(idMateriaPrima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(MateriaPrima materiaPrima1)
  {
    var collection = liteDB.GetCollection<MateriaPrima>(NomeDaTabela);
    collection.Upsert(MateriaPrima);
  }

  //----------------------------------------------------------------------------
}