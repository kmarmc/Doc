using LiteDB;

namespace Modelos
{
public class Acabamento
{
    [BsonId]
    public int Id {get;set;}
    public int Quantidade{get;set;}
    public string Aviamentos{get;set;}
    public int NumeroDaOp{get;set;}
}
}