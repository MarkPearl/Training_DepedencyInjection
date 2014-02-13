using System;

namespace DependencyInjection_Worksheet
{
    public interface IPublicHolidayNotifier
    {
        string GenerateNotification();
    }

    public class PublicHolidayNotifier : IPublicHolidayNotifier
    {
        private readonly IDateGenerator _dateGenerator;

        public PublicHolidayNotifier(IDateGenerator dateGenerator)
        {
            _dateGenerator = dateGenerator;
        }

        public string GenerateNotification()
        {
            if (_dateGenerator.Generate() == new DateTime(2013, 6, 17))
                return "Today is Youth Day";
            return "Today is a normal day";
        }
    }
}