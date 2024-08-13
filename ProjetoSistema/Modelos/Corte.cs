using LiteDB;

namespace Modelos
{
public class Corte
{
    [BsonId]
    public int id {get;set;}
    public int Quantidade{get;set;}
    public string Cortador{get;set;}
    public int NumeroDaOp {get;set;}
}
}   