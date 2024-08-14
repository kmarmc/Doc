using LiteDB;

namespace Modelos
{
public class Cliente : Registro
{
    [BsonId]
   public int Id {get;set;}
   public string Nome{get; set;}
   public string Endereco{get;set;}
   public string Email{get;set;}
   public string Telefone{get;set;}
}   
}
