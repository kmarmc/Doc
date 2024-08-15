using LiteDB;

namespace Modelos
{
public class Produto : Registro
{
    [BsonId]
    public int Id {get;set;}
    public string Nome{get;set;}
    public int NumeroDaOp{get;set;}
    public string NomeDoTecido{get;set;}
    public decimal QuantidadeDeTecido{get;set;} 
    public decimal Preco{get;set;}
    public string Linhas{get;set;}
    public string Aviamentos{get;set;}
    public string Cortador{get;set;}
    public string Estampa{get;set;}
    public string Grade{get;set;}
}
}