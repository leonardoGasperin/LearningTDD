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
        string aux;
        int cnt = 0;
        for(int i = 0; i < 1000; i++)
        {
            aux = Conversa.Falar(i);
            if(i % 2 == 0 && aux != "Oi")
                cnt++;
            if(i % 2 != 0 && aux != "Tchau")
                cnt++;
        }
        Assert.That(cnt, Is.Zero);
    }

    [Test]
    public void Test2()
    {
        var t = new Conversa();
        int maxValueWithouRepeat = 4;
        List<string> aux = new()
        {
            t.FalaAleatoria()
        };
        for (int i = 0; i < 1000; i++)
        {
            var v = t.FalaAleatoria();
            if(!aux.Contains(v))
            {
                aux.Add(v);
            }
            if (aux.Count == 4)
                break;
        }
        Assert.AreEqual(aux.Count, 4);
    }
}