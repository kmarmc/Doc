using LiteDB;

namespace Modelos
{
public class Almoxarifado : Registro
{
    [BsonId]
     public int Id {get;set;}
    public int Quantidade {get;set;}
    public string MateriaisEnvio {get;set;}
    public int NumeroDaOp {get;set;}
}
}