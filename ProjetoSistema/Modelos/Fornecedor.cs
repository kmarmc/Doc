using LiteDB;

namespace ProjetoSistema.Modelos
{
    public class Fornecedor
    {
        [BsonId]
        public int Id {get;set;}
        public string Nome{get;set;}
        public string Endereco{get;set;}
        public string Email{get;set;}
        public  string Telefone{get;set;}
        public string TipoDeMateria{get;set;}
        public string NomeDeMateria{get;set;}
        public decimal ValorDeMateria{get;set;}
    }
}    