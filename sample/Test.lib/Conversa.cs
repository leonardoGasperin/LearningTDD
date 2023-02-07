namespace Test.lib;
public class Conversa
{
    private int cnt = 0;
    public string Falar()
    {
        if(cnt % 2 == 0)
        {
            return "Oi";
        }
        cnt++;

        return "Tchau";
    }

}
