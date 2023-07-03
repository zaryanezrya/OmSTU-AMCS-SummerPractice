namespace SpaceBattleLib.Tests;
using TechTalk.SpecFlow;
using SpaceBattleLib;

[Binding]
public class LinearMotionBDD
{
    [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
         public void ДопустимКосмическийКорабльНаходитсяВТочкеПространстваСКоординатами(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [Given(@"изменить положение в пространстве космического корабля невозможно")]
         public void ДопустимИзменитьПоложениеВПространствеКосмическогоКорабляНевозможно()
         {
             _scenarioContext.Pending();
         }

    [Given(@"скорость корабля определить невозможно")]
         public void ДопустимСкоростьКорабляОпределитьНевозможно()
         {
             _scenarioContext.Pending();
         }

    [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
         public void ДопустимКосмическийКорабльПоложениеВПространствеКоторогоНевозможноОпределить()
         {
             _scenarioContext.Pending();
         }

    [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
         public void ДопустимИмеетМгновеннуюСкорость(int p0, int p1)
         {
             _scenarioContext.Pending();
         }

    [When(@"происходит прямолинейное равномерное движение без деформации")]
         public void КогдаПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
         {
             _scenarioContext.Pending();
         }

    [Then(@"возникает ошибка Exception")]
         public void ТоВозникаетОшибкаException()
         {
             _scenarioContext.Pending();
         }

    [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
         public void ТоКосмическийКорабльПеремещаетсяВТочкуПространстваСКоординатами(int p0, int p1)
         {
             _scenarioContext.Pending();
         }
}