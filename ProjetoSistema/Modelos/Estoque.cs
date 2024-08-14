using LiteDB;

namespace Modelos
{
public class Estoque : Registro
{
    [BsonId]
    public int Id {get;set;}
    public int Quantidade{get;set;}
    public string Cliente{get;set;}
    public int NumeroDaOp{get;set;}
}
}