using LiteDB;

namespace Modelos
{
public class Estoque
{
    [BsonId]
    public int id {get;set;}
    public int Quantidade{get;set;}
    public string Cliente{get;set;}
    public int NumeroDaOp{get;set;}
}
}