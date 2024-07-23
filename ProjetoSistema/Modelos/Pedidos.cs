namespace Modelos
{
public class Pedidos
{
    string Nome;
    string Endereco;
    string Email;
    string Telefone;
    string Produto;
    decimal ValorUnidade;
    int Quantidade;
    decimal ValorTotal;
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
     public void SetProduto (string Produto)
    {
        this.Produto = Produto;
    }
    public string GetProduto ()
    {
        return Produto;
    }
     public void SetValorUnidade (decimal ValorUnidade)
    {
        this.ValorUnidade = ValorUnidade;
    }
    public decimal GetValorUnidade ()
    {
        return ValorUnidade;
    }
     public void SetQuantidade (int Quantidade)
    {
        this.Quantidade = Quantidade;
    }
    public int GetQuantidade ()
    {
        return Quantidade;
    }
    public void SetValorTotal (decimal ValorTotal)
    {
        this.ValorTotal = ValorTotal;
    }
    public decimal GetValorTotal ()
    {
        return ValorTotal;
    }
}
}