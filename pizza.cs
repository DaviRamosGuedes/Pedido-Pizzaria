class Pizza
{
    private string Nome;
    private float Preco;

    public Pizza(string Nome, float Preco)
    {
        this.Nome = Nome;
        this.Preco = Preco;
    }

    public string getNome()
    {
        return Nome;
    }
    public void setNome(string N)
    {
        Nome = N.ToUpper();
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
