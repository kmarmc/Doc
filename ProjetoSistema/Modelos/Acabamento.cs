namespace Modelos
{
public class Acabamento
{
    int Quantidade;
    string Aviamentos;
    int NumeroDaOp;
      public void SetQuantidade (int Quantidade)
    {
        this.Quantidade = Quantidade;
    }
    public int GetQuantidade ()
    {
        return Quantidade;
    }
      public void SetAviamentos (string Aviamentos)
    {
        this.Aviamentos = Aviamentos;
    }
    public string GetAviamentos ()
    {
        return Aviamentos;
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