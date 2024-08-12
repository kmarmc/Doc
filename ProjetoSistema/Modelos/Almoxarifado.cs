using LiteDB;

namespace Modelos

public class Almoxarifado
{
    [BsonId]
     public int id {get;set;}
    public int Quantidade {get;set;}
    public string MateriaisEnvio {get;set;}
    public int NumeroDaOp {get;set;}
   
}