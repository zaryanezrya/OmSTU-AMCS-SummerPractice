using spaceBattle;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace spaceBattleTests
{
    [Binding]
    public class SpaceShipMoving
    {
        private readonly ScenarioContext scenario_Context;
        SpaceShip spaceShip = new SpaceShip();
        double[]? actualCoordinates;
        Exception exception = new Exception();

        public SpaceShipMoving(ScenarioContext scenarioContext)
        {
            scenario_Context = scenarioContext;
        }

        [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
        public void GivenCoordinates(double p0, double p1)
        {
            spaceShip.SetCoordinates(p0, p1);
        }

        [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
        public void GivenSpeedVector(double p0, double p1)
        {
            spaceShip.SetSpeedCoordinates(p0, p1);
        }

        [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
        public void GivenImpossibleCoordinates()
        {
        }

        [Given(@"скорость корабля определить невозможно")]
        public void GivenImpossibleSpeedVector()
        {
        }

        [Given(@"изменить положение в пространстве космического корабля невозможно")]
        public void GivenImpossibleAction()
        {
            spaceShip.NotMoving();
        }

        [When(@"происходит прямолинейное равномерное движение без деформации")]
        public void WhenMovingAction()
        {
            try
            {
                actualCoordinates = spaceShip.MovingAction();
            }
            catch (Exception exc)
            {
                exception = exc;
            }
        }

        [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
        public void ThenSpaceshipMovingToCoordinates(double p0, double p1)
        {
            spaceShip.MovingAction().Should().BeEquivalentTo(new double[] { p0, p1 });
        }

        [Then(@"возникает ошибка Exception")]
        public void ThenThrowsException()
        {
            Assert.Equal("check the values, maybe something is set as null!", exception.Message);
        }
    }
}

