using SpaceBattle;
using TechTalk.SpecFlow;

namespace SpaceBattleTests{
[Binding]
public class ТопливоКорабля
{
    private readonly ScenarioContext _scenarioContext;
    private double _fuelhas;
    private double _fueltaken;
    private Lazy<double> _result = default!;
    public ТопливоКорабля(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    [Given(@"космический корабль имеет топливо в объеме (.*) ед")]
    public void ДопустимКосмическийКорабльИмеетТопливоВОбъеме(double p0)
    {
        _fuelhas = p0;
    }

    [Given(@"имеет скорость расхода топлива при движении (.*) ед")]
    public void ИмеетСкоростьРасходаТопливаПриДвижении(double p0)
    {
        _fueltaken = p0;
    }

    [When(@"происходит прямолинейное равномерное движение без деформации")]
    public void ПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
    {
        _result = new Lazy<double>(() => ShipFuel.ShipMoving(_fuelhas, _fueltaken));
    }

    [Then(@"новый объем топлива космического корабля равен (.*) ед")]
    public void НовыйОбъемТопливаКосмическогоКорабляРавен(double p0)
    {
        Assert.Equal(p0, _result.Value);
    }

    [Then(@"возникает ошибка Exception")]
    public void ВозникаетОшибкаException ()
    {
        Assert.Throws<Exception>(() => _result.Value);
    }
}}