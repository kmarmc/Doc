
public class Fornecedor
{
    string Nome;
    string Endereco;
    string Email;
    string Telefone;
    string TipoDeMateria;
    string NomeDeMateria;
    decimal ValorDeMateria; 

    public void SetNome (string Nome)
    {
        this.Nome = Nome;
    }
    public string GetNome ()
    {
        return Nome;
    }
     public void SetEndereco (string Endereco)
    {
        this.Endereco = Endereco;
    }
    public string GetEndereco ()
    {
        return Endereco;
    }
     public void SetEmail (string Email)
    {
        this.Email = Email;
    }
    public string GetEmail ()
    {
        return Email;
    }
     public void SetTelefone (string Telefone)
    {
        this.Telefone = Telefone;
    }
    public string GetTelefone ()
    {
        return Telefone;
    }
     public void SetTipoDeMateria (string TipoDeMateria)
    {
        this.TipoDeMateria = TipoDeMateria;
    }
    public string GetTipoDeMateria ()
    {
        return TipoDeMateria;
    }
      public void SetNomeDeMateria (string NomeDeMateria)
    {
        this.NomeDeMateria = NomeDeMateria;
    }
    public string GetNomeDeMateria ()
    {
        return NomeDeMateria;
    }
     public void SetValorDeMateria (decimal ValorDeMateria)
    {
        this.ValorDeMateria = ValorDeMateria;
    }
    public decimal GetValorDeMateria ()
    {
        return ValorDeMateria;
    }
}