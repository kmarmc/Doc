using LiteDB;

namespace Modelos
{
public class Bordado
{
    [BsonId]
    public int Id {get;set;}
    int Quantidade {get;set;}
    string Linhas {get;set;}
    int NumeroDaOp {get;set;}
     
}
}