namespace Modelos

public class Produto 
{
     {BsonId}
    public int id {get;set;}
    int NumeroDaOp{get;set;}
    string NomeDoTecido{get;set;}
    decimal QuantidadeDeTecido{get;set;} 
    decimal Preco{get;set;}
    string Linhas{get;set;}
    string Aviamentos{get;set;}
    string Cortador{get;set;}
    string Estampa{get;set;}
    string Grade{get;set;}
}