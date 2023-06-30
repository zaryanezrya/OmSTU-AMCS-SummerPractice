namespace SalonLib.Test;

public class ServiceLocatorTest
{
    [Fact]
    public void Service1Test()
    {
<<<<<<< HEAD
        var expected = "В читальном зале";
=======
        var expected = "В кабинете";
>>>>>>> broken/OsipBrik
        var actual = SalonLib.ServiceLocator.GetService("Читать стихи");
        Assert.Equal(expected, actual);
    }

    [Fact]
<<<<<<< HEAD
<<<<<<< HEAD
    public void Service2Test()
    {
        var expected = "У рояля";
        var actual = SalonLib.ServiceLocator.GetService("Петь романсы");
        Assert.Equal(expected, actual);
    }
=======
    public void Service2Test()
    {
        var expected = "В читальном зале";
        var actual = SalonLib.ServiceLocator.GetService("Петь романсы");
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Service3Test()
    {
        var expected = "В читальном зале";
        var actual = SalonLib.ServiceLocator.GetService("Писать статьи");
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Service4Test()
    {
        var expected = "За карточным столом";
        var actual = SalonLib.ServiceLocator.GetService("Играть в карты");
        Assert.Equal(expected, actual);
    }
>>>>>>> broken/VladimirMayakovsky
}
=======
    public void Service3Test()
    {
        var expected = "В кабинете";
        var actual = SalonLib.ServiceLocator.GetService("Писать статьи");
        Assert.Equal(expected, actual);
    }
}
>>>>>>> broken/OsipBrik
