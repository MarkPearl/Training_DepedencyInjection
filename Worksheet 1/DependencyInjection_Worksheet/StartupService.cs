namespace DependencyInjection_Worksheet
{
    public class StartupService
    {
        private readonly IPublicHolidayNotifier _holidayNotifier;
        private readonly IWriter _writer;

        public StartupService(IPublicHolidayNotifier holidayNotifier, IWriter writer )
        {
            _holidayNotifier = holidayNotifier;
            _writer = writer;
        }

        public void Initiate()
        {
            _writer.WriteLine("Hello World");
            //_writer.WriteLine(_holidayNotifier.GenerateNotification());
            _writer.WriteLine("Say Goodbye");
        }
    }
}