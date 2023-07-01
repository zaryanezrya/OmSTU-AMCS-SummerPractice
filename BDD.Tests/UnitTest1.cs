namespace BDD.Tests;
using SquareEquationLib;
using TechTalk.SpecFlow;

[Binding]
public class StepDefinitions
{
    private double Epsilon = 1e-9;
    private double[] ratio = new double[3];
    private double[] res = new double[0];
    private Exception excep = new Exception();
    [When("вычисляются корни квадратного уравнения")]
    public void AddTheRoots()
    { 
        try 
        {
            res = SquareEquation.Solve(ratio[0],ratio[1],ratio[2]);
        }
        catch (Exception e)
        {
            excep =  e;
        }
    }
    [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), (.*)\)")]
    public void GiveCoefficients(string a, string b, string c) 
    {
        string[] coefic = new string[] {a, b, c};
        
        for (int i = 0; i < 3; i++)
        {
            if (coefic[i] == "Double.NegativeInfinity")
                ratio[i] = double.NegativeInfinity;
            else if (coefic[i] == "Double.PositiveInfinity")
                ratio[i] = double.PositiveInfinity;
            else if (coefic[i] == "NaN")
                ratio[i] = double.NaN;
            else
                ratio[i] = Convert.ToDouble(coefic[i]);
        }
    }

    [Then("выбрасывается исключение ArgumentException")]
    public void ThrowException()
    {
        Assert.ThrowsAsync<ArgumentException>(() => throw excep);
    }

    [Then(@"квадратное уравнение имеет два корня \((.*), (.*)\) кратности один")]
    public void TwoRoots(double x1, double x2)
    {
        double[] res2 = new double[] {x1, x2};
        Array.Sort(res);
        Array.Sort(res2);
        
        for (int i = 0; i < res2.Length; i++)
        {
            Assert.Equal(res[i], res2[i]);
        }
    }

    [Then(@"квадратное уравнение имеет один корень (.*) кратности два")]
    public void OneRoot(double x1)
    {
        double[] res2 = new double[] {x1};
        
        for (int i = 0; i < res2.Length; i++)
        {
            Assert.Equal(res[i], res2[i]);
        }
    }

    [Then(@"множество корней квадратного уравнения пустое")]
    public void Nothing()
    {
        Assert.Empty(res);
    }
}