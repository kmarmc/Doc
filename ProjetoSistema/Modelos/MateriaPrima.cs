using LiteDB;

namespace Modelos
{
public class MateriaPrima : Registro
{
     [BsonId]
    public int Id {get;set;}
    public string Nome{get;set;}
    public string Tipo{get;set;}
    public decimal Valor{get;set;}
    public int Unidade{get;set;}
    public int IdMateria{get;set;}
    public int Quantidade{get;set;}
}   
}