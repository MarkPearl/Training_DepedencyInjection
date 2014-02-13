using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;

namespace DependencyInjection_Worksheet
{
    [TestFixture]
    public class PublicHolidayNotifierTests
    {
        [Test]
        public void IsYouthDayOnThe17June2013()
        {
            var date = MockRepository.GenerateStub<IDateGenerator>();
            date.Expect(x => x.Generate()).Return(new DateTime(2013, 6, 17));

            var sut = new PublicHolidayNotifier(date);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is Youth Day"));
        }

        [Test]
        public void IsNormalDayOnThe18June2013()
        {
            var date = MockRepository.GenerateStub<IDateGenerator>();
            date.Expect(x => x.Generate()).Return(new DateTime(2013, 6, 18));

            var sut = new PublicHolidayNotifier(date);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is a normal day"));
        }

        [Test]
        public void DemonstrateBehvaiouralTest()
        {
            var holidayNotifier = MockRepository.GenerateStub<IPublicHolidayNotifier>();
            var writer = MockRepository.GenerateStub<IWriter>();

            holidayNotifier.Expect(x => x.GenerateNotification()).Repeat.AtLeastOnce().Return("Hello");

            var sut = new StartupService(holidayNotifier, writer);

            sut.Initiate();

            holidayNotifier.VerifyAllExpectations();
        }
    }
}
