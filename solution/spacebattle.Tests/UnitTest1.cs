using TechTalk.SpecFlow;
using SpaceBattle;

namespace spacebattle.Tests;

[Binding]
public class UnitTest
{
    double posX, posY;
    double speedX, speedY;
    double[] pos = new double[2];
    double[] speed = new double[2];
    bool status = true;

    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
    public void Step1(double x, double y) {
        posX = x;
        posY = y;
    }

    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
    public void Step2(double x, double y) {
        speedX = x;
        speedY = y;
    }

    [When("происходит прямолинейное равномерное движение без деформации")]
    public void Step3() {
    }

    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
    public void Step4(double x, double y) {
        var pos = new double[] {posX, posY};
        var speed = new double[] {speedX, speedY};
        var extented = new double[] {x, y};
        for(int i = 0; i < extented.Length; i++) {
            Assert.Equal(extented[i], Spaceship.Move(pos, speed, status)[i]);
        }
    }

    [Given("космический корабль, положение в пространстве которого невозможно определить")]
    public void Step5() {
        posX = double.NaN;
        posY = double.NaN;
    }

    [Then("возникает ошибка Exception")]
    public void Step6() {
        var pos = new double[] {posX, posY};
        var speed = new double[] {speedX, speedY};
        Assert.Throws<System.Exception>(
            () => Spaceship.Move(pos, speed, status)
        );
    }

    [Given("скорость корабля определить невозможно")]
    public void Step7() {
        speedX = double.NaN;
        speedY = double.NaN;
    }

    [Given("изменить положение в пространстве космического корабля невозможно")]
    public void Step8() {
        status = false;
    }
}