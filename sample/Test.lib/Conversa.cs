using Test.lib.Models;

namespace Test.lib;
public class Conversa
{
    private readonly string[] randonTalk = { "papagaio", "sábado", "quem sabe amanhã", "não" };
    private List<Contato> contatoLista = new();

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
        if (contatoLista is null)
            throw new Exception("Lista de contato vazia");
        if (contatoLista.Count < 0)
            throw new Exception("Lista de contato com erro.");

        return contatoLista;
    }

    public void AddContato(Contato addContact)
    {
        if (addContact.Name.Length is 0)
            throw new Exception("Nome Invalido");
        if (!long.TryParse(addContact.Telefone, out _) || (addContact.Telefone.Length is < 9 || addContact.Telefone.Length is > 14))
            throw new Exception("Telefone Invalido");
        
        contatoLista.Add(addContact);
    }

    public Contato SearchContato(string telefone)
    {
        if (telefone is null || !long.TryParse(telefone, out long _))
            throw new Exception("Numero invalido para busca");
        return contatoLista.First(x => x.Telefone == telefone);
    }

    public void RemoveContato(string telefone)
    {
        var removeContato = SearchContato(telefone);
        if (removeContato is null)
            throw new Exception("Contato nao existente");

        contatoLista.Remove(removeContato);
    }
}
