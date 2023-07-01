using TechTalk.SpecFlow;
using SpaceBattle;

[Binding]
public class SpaceBattleTests
{
    private bool Position = true, Speed = true, Movement = true;
    private double[] coordinates = new double[2], speed = new double[2];

    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
    public void ДопустимКосмическийКорабльНаходитсяВТочкеПространстваСКоординатами(double p0, double p1)
    {
        coordinates[0] = p0;
        coordinates[1] = p1;
    }

    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
    public void ИИмеетМгновеннуюСкорость(double p0, double p1)
    {
        speed[0] = p0;
        speed[1] = p1;
    }

    [Given(@"скорость корабля определить невозможно")]
        public void ДопустимСкоростьКорабляОпределитьНевозможно()
        {
            Speed = false;
        }
    
    [Given(@"изменить положение в пространстве космического корабля невозможно")]
        public void ДопустимИзменитьПоложениеВПространствеКосмическогоКорабляНевозможно()
        {
            Movement = false;
        }

    [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
        public void ДопустимКосмическийКорабльПоложениеВПространствеКоторогоНевозможноОпределить()
        {
            Position = false;
        }

    [When(@"происходит прямолинейное равномерное движение без деформации")]
    public void ПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
    {
        try{
        coordinates = Spacebattle.ship(coordinates, speed, Position, Speed, Movement);
        }
        catch{}
    }

    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
    public void КосмическийКорабльПеремещаетсяВТочкуПространстваСКоординатами(double p0, double p1)
    {
        double[] expected = {p0, p1};
        Assert.Equal(expected, coordinates);
    }

    [Then(@"возникает ошибка Exception")]
        public void ТоВозникаетОшибкаException()
        {
            Assert.Throws<System.Exception>(() => Spacebattle.ship(coordinates, speed, Position, Speed, Movement));
        }
}