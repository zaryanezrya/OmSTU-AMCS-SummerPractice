namespace SpaceBattleLib.Tests;
using TechTalk.SpecFlow;
using SpaceBattleLib;

[Binding, Scope(Feature = "Прямолинейное движение")]
public class LinearMotionBDD
{
    private LinearMotion lm = new LinearMotion();
    private Exception _actualException = new Exception();

    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
         public void ДопустимКосмическийКорабльНаходитсяВТочкеПространстваСКоординатами(int p0, int p1)
         {
            lm.Coordinates[0] = p0; lm.Coordinates[1] = p1;
         }

    [Given(@"изменить положение в пространстве космического корабля невозможно")]
         public void ДопустимИзменитьПоложениеВПространствеКосмическогоКорабляНевозможно()
         {
            lm.relocate = false;
         }

    [Given(@"скорость корабля определить невозможно")]
         public void ДопустимСкоростьКорабляОпределитьНевозможно()
         {
            lm.Speed[0] = double.NaN; lm.Speed[1] = double.NaN;
         }

    [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
         public void ДопустимКосмическийКорабльПоложениеВПространствеКоторогоНевозможноОпределить()
         {
            lm.Coordinates[0] = double.NaN; lm.Coordinates[1] = double.NaN;
         }

    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
         public void ДопустимИмеетМгновеннуюСкорость(int p0, int p1)
         {
            lm.Speed[0] = p0; lm.Speed[1] = p1;
         }

    [When(@"происходит прямолинейное равномерное движение без деформации")]
         public void КогдаПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
         {
            try
            {
               lm.Movement();
            }

            catch(Exception e)
            {
               _actualException = e;
            }
         }

    [Then(@"возникает ошибка Exception")]
         public void ТоВозникаетОшибкаException()
         {
            Assert.ThrowsAsync<Exception>(() => throw _actualException);
         }

    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
         public void ТоКосмическийКорабльПеремещаетсяВТочкуПространстваСКоординатами(int p0, int p1)
         {
            double[] _expectedResult = {p0, p1};

            for (int i = 0; i < _expectedResult.Length;i++)
            {
                Assert.Equal(_expectedResult[i], lm.Coordinates[i], 6);
            }
         }
}

[Binding, Scope(Feature = "Движения только при достаточном количестве топлива")]
public class MovementFuelBDD
{
   private MovementFuel mf = new MovementFuel();
   private Exception _actualException = new Exception();

   [Given(@"космический корабль имеет топливо в объеме (.*) ед")]
         public void ДопустимКосмическийКорабльИмеетТопливоВОбъемеЕд(int p0)
         {
            mf.amountFuel = p0;
         }

   [Given(@"имеет скорость расхода топлива при движении (.*) ед")]
         public void ДопустимИмеетСкоростьРасходаТопливаПриДвиженииЕд(int p0)
         {
            mf.fuelConsumption = p0;
         }

   [When(@"происходит прямолинейное равномерное движение без деформации")]
         public void КогдаПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
         {
            try
            {
               mf.AbilityMove();
            }

            catch(Exception e)
            {
               _actualException = e;
            }
         }

   [Then(@"новый объем топлива космического корабля равен (.*) ед")]
         public void ТоНовыйОбъемТопливаКосмическогоКорабляРавенЕд(int p0)
         {
            Assert.Equal(p0, mf.amountFuel, 6);
         }

   [Then(@"возникает ошибка Exception")]
         public void ТоВозникаетОшибкаException()
         {
            Assert.ThrowsAsync<Exception>(() => throw _actualException);
         }
}

[Binding, Scope(Feature = "Возможность разворота")]
public class ReversalPossibilityBDD
{
   private ReversalPossibility rp = new ReversalPossibility();
   private Exception _actualException = new Exception();

   [Given(@"космический корабль, угол наклона которого невозможно определить")]
         public void ДопустимКосмическийКорабльУголНаклонаКоторогоНевозможноОпределить()
         {
            rp.angleInclination = double.NaN;
         }

   [Given(@"имеет мгновенную угловую скорость (.*) град")]
         public void ДопустимИмеетМгновеннуюУгловуюСкоростьГрад(int p0)
         {
            rp.angularVelocity = p0;
         }

   [Given(@"космический корабль имеет угол наклона (.*) град к оси OX")]
         public void ДопустимКосмическийКорабльИмеетУголНаклонаГрадКОсиOX(int p0)
         {
            rp.angleInclination = p0;
         }

   [Given(@"мгновенную угловую скорость невозможно определить")]
         public void ДопустимМгновеннуюУгловуюСкоростьНевозможноОпределить()
         {
            rp.angularVelocity = double.NaN;
         }

   [Given(@"невозможно изменить уголд наклона к оси OX космического корабля")]
         public void ДопустимНевозможноИзменитьУголдНаклонаКОсиOXКосмическогоКорабля()
         {
            rp.reversalPossibility = false;
         }

   [When(@"происходит вращение вокруг собственной оси")]
         public void КогдаПроисходитВращениеВокругСобственнойОси()
         {
            try
            {
               rp.Reversal();
            }
            catch(Exception e)
            {
                  _actualException = e;
            }
         }
   
   [Then(@"угол наклона космического корабля к оси OX составляет (.*) град")]
         public void ТоУголНаклонаКосмическогоКорабляКОсиOXСоставляетГрад(int p0)
         {
            Assert.Equal(p0, rp.angleInclination, 6);
         }

   [Then(@"возникает ошибка Exception")]
         public void ТоВозникаетОшибкаException()
         {
            Assert.ThrowsAsync<Exception>(() => throw _actualException);
         }
}