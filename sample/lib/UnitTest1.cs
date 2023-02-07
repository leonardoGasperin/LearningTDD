using Test.lib;

namespace lib;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var t = new Conversa();
        string aux = string.Empty;
        int cnt = 0;
        for(int i = 0; i < 1000; i++)
        {
            aux = t.Falar(i);
            if (i % 2 == 0 && aux != "Oi")
                cnt++;
            if(i % 2 != 0 && aux != "Tchau")
                cnt++;
        }
        Assert.That(cnt, Is.Zero);
    }

}