using Test.lib.Models;

namespace Test.lib;
public class Conversa
{
    private readonly string[] randonTalk = { "papagaio", "sábado", "quem sabe amanhã", "não" };
    private List<Contato> ContatoLista { get; set; }

    public static string Falar(int i)
    {
        if (i % 2 == 0)
        {
            return "Oi";
        }
        return "Tchau";
    }

    public string FalaAleatoria()
    {
        Random rnd = new();

        return randonTalk[rnd.Next(0, randonTalk.Length)];
    }

    public List<Contato> GetAllContato()
    {
        if (ContatoLista is null)
            throw new Exception("Lista de contato vazia");
        return ContatoLista;
    }

    public bool AddContato(Contato add)
    {
        if (add.Name.Count() is 0)
            throw new Exception("Nome Invalido");
        if (!long.TryParse(add.Telefone, out long n) || add.Telefone.Count() is < 9)
            throw new Exception("Telefone Invalido");
        ContatoLista.Add(add);

        return true;
    }
}
