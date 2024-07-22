public class Cliente
{
    string Nome;
    string Endereco;
    string Email;
    string Telefone;
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
}