class Bebida
{
    private string Nome;
    private float Preco;

    public Bebida(string Nome, float Preco)
    {
        this.Nome = Nome;
        this.Preco = Preco;
    }

    public string getNome()
    {
        return Nome;
    }
    public void setNome(string n)
    {
        Nome = n.ToUpper();
    }
    public float getPreco()
    {
        return Preco;
    }
    public void setPreco(float p)
    {
        Preco = p;
    }
}
