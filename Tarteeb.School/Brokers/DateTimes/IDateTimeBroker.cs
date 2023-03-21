using System;

namespace Tarteeb.School.Brokers.DateTimes
{
    public interface IDateTimeBroker
    {
        DateTimeOffset GetCurrentDateTime();    
    }
}