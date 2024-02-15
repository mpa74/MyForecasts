using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForecasts.Business.Enums;
public class Events
{
    public enum EventType
    {
        None = 0,
        Defaut = 1,

    }

    public enum IntervalType
    {
        Day = 0,
        Month = 1,
        Year = 2,
    }
}
