using Test.lib;
using Test.lib.Models;

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
        for (int i = 0; i < 1000; i++)
        {
            aux = Conversa.Falar(i);
            if (i % 2 == 0 && aux != "Oi")
                cnt++;
            if (i % 2 != 0 && aux != "Tchau")
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
            if (!aux.Contains(v))
            {
                aux.Add(v);
            }
            if (aux.Count == 4)
                break;
        }
        Assert.That(actual: maxValueWithouRepeat, Is.EqualTo(aux.Count));
    }

    [Test]
    public void Test3()
    {
        var t = new Conversa();
        Assert.Catch(() =>
        {
            t.AddContato(
                new Contato
                {
                    Name = "jao ze jao",
                    Telefone = "23456789"
                });
        });
        Assert.Catch(() =>
        {
            t.AddContato(
                new Contato
                {
                    Name = "",
                    Telefone = "123456789"
                });
        });
        Assert.Catch(() =>
        {
            t.AddContato(
                new Contato
                {
                    Name = "dsdw",
                    Telefone = "5234567558452159"
                });
        });
        Assert.Catch(() =>
        {
            t.AddContato(
                new Contato
                {
                    Name = "sq",
                    Telefone = "3456789"
                });
        });
        Assert.Catch(() =>
        {
            t.AddContato(
                new Contato
                {
                    Name = "sq",
                    Telefone = "d"
                });
        });
        Assert.DoesNotThrow(() =>
        {
            t.AddContato(
                new Contato
                {
                    Name = "Antonio Antonietta Tonny",
                    Telefone = "159487263"
                });
        });


    }

    [Test]
    public void Test4()
    {
        var t = new Conversa();

        t.AddContato(
        new Contato
        {
            Name = "Antonio Antonietta Tonny",
            Telefone = "159487263"
        });

        Assert.Catch(() =>
        {
            Assert.IsEmpty(t.GetAllContato());
        });
        Assert.Catch(() =>
        {
            Assert.Less(t.GetAllContato().Count, 0);
        });
        Assert.DoesNotThrow(() =>
        {
            t.GetAllContato();
        });
    }

    [Test]
    public void Test5()
    {
        var t = new Conversa();

        t.AddContato(
                new Contato
                {
                    Name = "Antonio Antonietta Tonny",
                    Telefone = "159487263"
                });

        int chk = t.GetAllContato().Count;
        Assert.Catch(() =>
        {
            t.RemoveContato("");
        });

        Assert.Catch(() =>
        {
            t.RemoveContato("a");
        });

        Assert.DoesNotThrow(() =>
        {
            t.RemoveContato("159487263");
        });
    }
}