namespace spacebattletests;
using SpaceBattle;
using TechTalk.SpecFlow;


[Binding]
public class StepDefinitions
{
    private double[] coords = new double[2];
    private double[] speed = new double[2];
    private bool possibility_of_movement = true;
    private Exception r_exp = new Exception();
    private SpaceBattle spaceBattle = new SpaceBattle();
    [When("происходит прямолинейное равномерное движение без деформации")]
    public void CalculatedTheMovementOfTheSpaceShip()
    {
        try 
        {
            coords = spaceBattle.Movement(coords,speed,possibility_of_movement);
        }
        catch (Exception e)
        {
            r_exp =  e;
        }
    }
    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
    public void GivenThePositionOfTheSpaceship(string x, string y) 
    {
        string[] i_coords = new string[2]{x,y}; 
        for (var i = 0; i<2; i++)
        {
            coords[i] = Convert.ToDouble(i_coords[i]);
        }
    }
    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
    public void GivenTheInstantSpeed(string x_speed, string y_speed) 
    {
        string[] i_speed = new string[2]{x_speed,y_speed}; 
        for (var i = 0; i<2; i++)
        {
            speed[i] = Convert.ToDouble(i_speed[i]);
        }
    }

    [Given("изменить положение в пространстве космического корабля невозможно")]
    public void GivenThePositionInSpace() 
    {
        possibility_of_movement = false;
    }

    [Given("космический корабль, положение в пространстве которого невозможно определить")]
    public void GivenThePositionCannotBeDetermined() 
    {
        for(var i=0; i<2; i++)
        {
            coords[i] = double.NaN;
        }
    }

    [Given("скорость корабля определить невозможно")]
    public void GivenTheSpeedOfTheShipCannotBeDetermined() 
    {
        for(var i=0; i<2; i++)
        {
            coords[i] = double.NaN;
        }
    }

    [Then(@"возникает ошибка Exception")]
    public void ThrowingException()
    {
        Assert.ThrowsAsync<Exception>(() => throw r_exp);
    }

    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
    public void MovingToAPoint(double x1, double x2)
    {
        double[] r_ans = new double[] {x1, x2};
        bool result = false;
        
        if (r_ans[0]==coords[0] & r_ans[1]==coords[1])
        {
            result = true;
        }

        Assert.True(result, "Incorrect");
    }
}