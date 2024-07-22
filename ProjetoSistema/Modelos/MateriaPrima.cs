public class MateriaPrima
{
    string Nome;
    string Tipo;
    decimal Valor;
    int Unidade;
    int IdMateria;
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

}