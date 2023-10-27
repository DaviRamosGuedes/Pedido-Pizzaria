class Cliente
{
    private string nome = "";

    public Cliente(string nome)
    {
        this.nome = nome;
    }

    public string getnome()
    {
        return nome;
    }
    public void setnome(string n)
    {
        nome = n.ToUpper();
    }
}