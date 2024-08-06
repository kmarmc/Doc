namespace Modelos
{
public class MateriaPrima
{
    string Nome;
    string Tipo;
    decimal Valor;
    int Unidade;
    int IdMateria;
    int Quantidade;
     public void SetNome (string Nome)
    {
        this.Nome = Nome;
    }
    public string GetNome ()
    {
        return Nome;
    }
     public void SetTipo (string Tipo)
    {
        this.Tipo = Tipo;
    }
    public string GetTipo ()
    {
        return Tipo;
    }
     public void SetValor(decimal Valor)
    {
        this.Valor = Valor;
    }
    public decimal GetValor ()
    {
        return Valor;
    }
     public void SetUnidade (int Unidade)
    {
        this.Unidade = Unidade;
    }
    public int GetUnidade ()
    {
        return Unidade;
    }
     public void SetIdMateria (int IdMateria)
    {
        this.IdMateria = IdMateria;
    }
    public int GetIdMateria ()
    {
        return IdMateria;
    }
    public void SetQuantidade(int Quantidade)
    {
        this.Quantidade = Quantidade;
    }
    public int GetQuantidade()
    {
            return Quantidade;
    }

}
}