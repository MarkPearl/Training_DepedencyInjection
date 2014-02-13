using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Worksheet
{
    public class DateGenerator :IDateGenerator
    {
        public DateTime Generate()
        {
            return DateTime.Now;
        }
    }
}
