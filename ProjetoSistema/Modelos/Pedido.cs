using LiteDB;

namespace Modelos
{
public class Pedido
{
     [BsonId]
    public int Id {get;set;}
    public string Nome{get;set;}
    public string Endereco{get;set;}
    public string Email{get;set;}
    public string Telefone{get;set;}
    public string Produto{get;set;}
    public decimal ValorUnidade{get;set;}
    public int Quantidade{get;set;}
    public decimal ValorTotal{get;set;}
    public string Cliente{get;set;}
    public int NumeroDaOp{get;set;}
}
}