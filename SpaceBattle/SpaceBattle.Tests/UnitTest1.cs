namespace SpaceBattle.Tests;
using SpaceBattle;
using TechTalk.SpecFlow;


[Binding, Scope(Feature = "Поворот")]
public class Rotation
{
    private double angle;
    private double eps=1e-9;
    private Exception exp = new Exception();
    private SpaceShip spaceShip = new SpaceShip();
    [When("происходит вращение вокруг собственной оси")]
    public void CalculatedTheRotate()
    {
        try 
        {
            angle = spaceShip.Rotation();
        }
        catch (Exception e)
        {
            exp =  e;
        }
    }
    
    [Given(@"космический корабль имеет угол наклона (.*) град к оси OX")]
    public void GivenAngle(double x) 
    {
        double angle2 = x;
        spaceShip.SetAngle(angle);
    }
    [Given(@"имеет мгновенную угловую скорость (.*) град")]
    public void GivenSpeed(double x_speed) 
    {
        double anglespeed = x_speed; 
        spaceShip.SetAnglSpeed(anglespeed);
    }

    [Given("невозможно изменить угол наклона к оси OX космического корабля")]
    public void GivenChangeAngle() 
    {
        bool ang = false;
        spaceShip.SetChangeAngle(ang);
    }

    [Given("космический корабль, угол наклона которого невозможно определить")]
    public void GivenNoneAngle() 
    {
        spaceShip.SetAngle(double.NaN);
    }

    [Given("мгновенную угловую скорость невозможно определить")]
    public void GivenTheUndefinedAngulanSpeedOfTheSpaceShip() 
    {
        spaceShip.SetAnglSpeed(double.NaN);
    }

    [Then(@"угол наклона космического корабля к оси OX составляет (.*) град")]
    public void ThrowingException(double x1)
    {
        bool result = false;
        
        if ((angle-x1)<eps)
        {
            result = true;
        }

        Assert.True(result);
    }
    
    [Then(@"возникает ошибка Exception")]
    public void ThrowingException()
    {
        Assert.ThrowsAsync<Exception>(() => throw exp);
    }
}


[Binding,Scope(Feature = "расход топлива")]
public class MovementFuel
{
    private double fuel;
    private double eps=1e-9;
    private Exception exp = new Exception();
    private SpaceShip spaceShip = new SpaceShip();
    [When("происходит прямолинейное равномерное движение без деформации")]
    public void CalculatedeMovementFuel()
    {
        try 
        {
            fuel = spaceShip.MovementFuel();
        }
        catch (Exception e)
        {
            exp =  e;
        }
    }

    [Given(@"космический корабль имеет топливо в объеме (.*) ед")]
    public void GivenTheFuelQuantityOfTheSpaceship(double x) 
    {
        spaceShip.SetFuel(x);
    }

    [Given(@"имеет скорость расхода топлива при движении (.*) ед")]
    public void GivenFuelF(double x_speed) 
    { 
        spaceShip.SetFuelF(x_speed);
    }

    [Then(@"новый объем топлива космического корабля равен (.*) ед")]
    public void CalcNewFuel(double x)
    {
        double res = x;
        bool result = false;
        
        if (Math.Abs(fuel-x)<eps)
        {
            result = true;
        }

        Assert.True(result);
    }

    [Then(@"возникает ошибка Exception")]
    public void ThrowingException()
    {
        Assert.ThrowsAsync<Exception>(() => throw exp);
    }
}

[Binding,Scope(Feature = "Перемещение корабля")]
public class MovmentTests
{
    private double[] pos = new double[2];
    private Exception exp = new Exception();
    private SpaceShip spaceShip = new SpaceShip();
    [When("происходит прямолинейное равномерное движение без деформации")]
    public void CalculatedTheMovement()
    {
        try 
        {
            pos = spaceShip.Movement();
        }
        catch (Exception e)
        {
            exp =  e;
        }
    }
    
    [Then(@"возникает ошибка Exception")]
    public void ThrowingException()
    {
        Assert.ThrowsAsync<Exception>(() => throw exp);
    }
    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
    public void GivenThePosition(double x, double y) 
    {
        double[] in_coords = new double[2]{x,y};
        spaceShip.SetPosition(in_coords);
    }
    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
    public void GivenSpeed(double x_speed, double y_speed) 
    {
        double[] speed = new double[2]{x_speed,y_speed}; 
        spaceShip.SetSpeed(speed);
    }

    [Given("изменить положение в пространстве космического корабля невозможно")]
    public void GivenThePositionInSpace() 
    {
        bool posin = false;
        spaceShip.SetSPosOfMove(posin);
    }

    [Given("космический корабль, положение в пространстве которого невозможно определить")]
    public void GivenThePositionCannotBeDetermined() 
    {
        double[] pos2 = new double[2]{double.NaN,double.NaN};
        spaceShip.SetPosition(pos2);
    }

    [Given("скорость корабля определить невозможно")]
    public void GivenTheSpeedOfTheShipCannotBeDetermined() 
    {
        double[] speed = new double[2]{double.NaN,double.NaN}; 
        spaceShip.SetSpeed(speed);
    }
    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
    public void MovingToAPoint(double x1, double x2)
    {
        double[] r_ans = new double[] {x1, x2};
        bool result = false;
        
        if (r_ans[0]==pos[0] & r_ans[1]==pos[1])
        {
            result = true;
        }

        Assert.True(result);
    }
}