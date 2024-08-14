using LiteDB;

namespace Modelos
{
public class Corte : Registro
{
    [BsonId]
    public int Id {get;set;}
    public int Quantidade{get;set;}
    public string Cortador{get;set;}
    public int NumeroDaOp {get;set;}
}
}   