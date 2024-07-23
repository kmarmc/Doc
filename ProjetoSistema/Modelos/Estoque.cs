namespace Modelos
{
public class Estoque
{
    int Quantidade;
    string Cliente;
    int NumeroDaOp;
     public void SetQuantidade (int Quantidade)
    {
        this.Quantidade = Quantidade;
    }
    public int GetQuantidade ()
    {
        return Quantidade;
    }
      public void SetCliente (string Cliente)
    {
        this.Cliente = Cliente;
    }
    public string GetCliente ()
    {
        return Cliente;
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