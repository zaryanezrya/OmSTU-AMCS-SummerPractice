namespace SpaceBattle.Tests;
using SpaceBattle;
using TechTalk.SpecFlow;


[Binding]
public class StepDefinitions
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
        spaceShip.SetSPosOfMove(false);
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

        Assert.True(result, "Incorrect");
    }
}