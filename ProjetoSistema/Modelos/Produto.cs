namespace Modelos
{
public class Produto 
{
    int NumeroDaOp;
    string NomeDoTecido;
    decimal QuantidadeDeTecido; 
    decimal Preco;
    string Linhas;
    string Aviamentos;
    string Cortador;
    string Estampa;
    string Grade;
     public void SetNumeroDaOp (int NumeroDaOp)
    {
        this.NumeroDaOp = NumeroDaOp;
    }
    public int GetNumeroDaOp ()
    {
        return NumeroDaOp;
    }
     public void SetNomeDoTecido (string NomeDoTecido)
    {
        this.NomeDoTecido = NomeDoTecido;
    }
    public string GetNomeDoTecido ()
    {
        return NomeDoTecido;
    }
     public void SetQuantidadeDeTecido (decimal QuantidadeDeTecido)
    {
        this.QuantidadeDeTecido = QuantidadeDeTecido;
    }
    public decimal GetQuantidadeDeTecido ()
    {
        return QuantidadeDeTecido;
    }
     public void SetPreco (decimal Preco)
    {
        this.Preco = Preco;
    }
    public decimal GetPreco ()
    {
        return Preco;
    }
    public void SetLinhas (string Linhas)
    {
        this.Linhas = Linhas;
    }
    public string GetLinhas ()
    {
        return Linhas;
    }
     public void SetAviamentos (string Aviamentos)
    {
        this.Aviamentos = Aviamentos;
    }
    public string GetAviamentos ()
    {
        return Aviamentos;
    }
    public void SetCortador (string Cortador)
    {
        this.Cortador = Cortador;
    }
    public string GetCortador ()
    {
        return Cortador;
    }
     public void SetEstampa (string Estampa)
    {
        this.Estampa = Estampa;
    }
    public string GetEstampa ()
    {
        return Estampa;
    }
     public void SetGrade (string Grade)
    {
        this.Grade = Grade;
    }
    public string GetGrade ()
    {
        return Grade;
    }
}
}