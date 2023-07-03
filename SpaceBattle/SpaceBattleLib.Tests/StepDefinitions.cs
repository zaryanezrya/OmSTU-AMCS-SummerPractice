namespace SpaceBattleLib.Tests;
using TechTalk.SpecFlow;
using SpaceBattleLib;

[Binding]
public class LinearMotionBDD
{
    private double[] _Coordinates = new double[2];
    private double[] _Speed = new double[2];
    private double[] _actualResult = new double[2];
    private bool relocate = true;

    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
         public void ДопустимКосмическийКорабльНаходитсяВТочкеПространстваСКоординатами(int p0, int p1)
         {
            _Coordinates[0] = p0; _Coordinates[1] = p1;
         }

    [Given(@"изменить положение в пространстве космического корабля невозможно")]
         public void ДопустимИзменитьПоложениеВПространствеКосмическогоКорабляНевозможно()
         {
            relocate = false;
         }

    [Given(@"скорость корабля определить невозможно")]
         public void ДопустимСкоростьКорабляОпределитьНевозможно()
         {
            _Speed[0] = double.NaN; _Speed[1] = double.NaN;
         }

    [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
         public void ДопустимКосмическийКорабльПоложениеВПространствеКоторогоНевозможноОпределить()
         {
            _Coordinates[0] = double.NaN; _Coordinates[1] = double.NaN;
         }

    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
         public void ДопустимИмеетМгновеннуюСкорость(int p0, int p1)
         {
            _Speed[0] = p0; _Speed[1] = p1;
         }

    [When(@"происходит прямолинейное равномерное движение без деформации")]
         public void КогдаПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
         {
            try
            {
                _actualResult = SpaceBattle.Movement(_Coordinates, _Speed, relocate);
            }

            catch{}
         }

    [Then(@"возникает ошибка Exception")]
         public void ТоВозникаетОшибкаException()
         {
            Assert.ThrowsAsync<Exception>(() => SpaceBattle.Movement(_Coordinates, _Speed, relocate));
         }

    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
         public void ТоКосмическийКорабльПеремещаетсяВТочкуПространстваСКоординатами(int p0, int p1)
         {
            double[] _expectedResult = {p0, p1};

            for (int i = 0; i < _expectedResult.Length;i++)
            {
                Assert.Equal(_expectedResult[i], _actualResult[i], 6);
            }
         }
}