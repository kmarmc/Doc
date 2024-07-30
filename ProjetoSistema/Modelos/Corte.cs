namespace Modelos
{
public class Corte
{
    int Quantidade;
    string Cortador;
    int NumeroDaOp;
      public void SetQuantidade (int Quantidade)
    {
        this.Quantidade = Quantidade;
    }
    public int GetQuantidade ()
    {
        return Quantidade;
    }
      public void SetCortador (string Cortador)
    {
        this.Cortador = Cortador;
    }
    public string GetCortador ()
    {
        return Cortador;
    }
    public void SetNumeroDaOp (int NumeroDaOp)
    {
        this.NumeroDaOp = NumeroDaOp;
    }
    public int GetNumeroDaOp ()
    {
        return NumeroDaOp;
    }

}
}   