using LiteDB;

namespace Modelos
{
public class Bordado : Registro
{
    [BsonId]
    public int Id {get;set;}
    public int Quantidade {get;set;}
    public string Linhas {get;set;}
    public int NumeroDaOp {get;set;}
     
}
}