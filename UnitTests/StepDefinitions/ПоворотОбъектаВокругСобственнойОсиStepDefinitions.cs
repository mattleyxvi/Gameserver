using System;
using TechTalk.SpecFlow;

namespace UnitTests.StepDefinitions
{
    [Binding]
    public class ПоворотОбъектаВокругСобственнойОсиStepDefinitions
    {
        [Given(@"космический корабль имеет угол наклона (.*) град к оси OX")]
        public void GivenКосмическийКорабльИмеетУголНаклонаГрадКОсиOX(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"имеет мгновенную угловую скорость (.*) град")]
        public void GivenИмеетМгновеннуюУгловуюСкоростьГрад(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"происходит вращение вокруг собственной оси")]
        public void WhenПроисходитВращениеВокругСобственнойОси()
        {
            throw new PendingStepException();
        }

        [Then(@"угол наклона космического корабля к оси OX составляет (.*) град")]
        public void ThenУголНаклонаКосмическогоКорабляКОсиOXСоставляетГрад(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"космический корабль, угол наклона которого невозможно определить")]
        public void GivenКосмическийКорабльУголНаклонаКоторогоНевозможноОпределить()
        {
            throw new PendingStepException();
        }

        [Then(@"возникает ошибка при повороте Exception")]
        public void ThenВозникаетОшибкаПриПоворотеException()
        {
            throw new PendingStepException();
        }

        [Given(@"мгновенную угловую скорость невозможно определить")]
        public void GivenМгновеннуюУгловуюСкоростьНевозможноОпределить()
        {
            throw new PendingStepException();
        }

        [Given(@"невозможно изменить угол наклона к оси OX космического корабля")]
        public void GivenНевозможноИзменитьУголНаклонаКОсиOXКосмическогоКорабля()
        {
            throw new PendingStepException();
        }
    }
}
