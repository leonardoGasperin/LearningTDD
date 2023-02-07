namespace Test.lib;
public class Conversa
{
    private readonly string[] randonTalk = { "papagaio", "sábado", "quem sabe amanhã", "não" };

    public static string Falar(int i)
    {
        if(i % 2 == 0)
        {
            return "Oi";
        }
        return "Tchau";
    }

    public string FalaAleatoria()
    {
        Random rnd= new();

        return randonTalk[rnd.Next(0, randonTalk.Length)];
    }

}
