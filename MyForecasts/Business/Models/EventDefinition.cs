using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyForecasts.Business.Enums.Events;

namespace MyForecasts.Business.Models;
public class EventDefinition
{
    public string EventId { get; set; }
    public string EventName { get; set; } = string.Empty;
    public string EventDescription { get; set; }
    public EventType EventType { get; set; } = EventType.Defaut;

    /// <summary>
    /// Как часто срабатывает событие
    /// </summary>
    public double Interval { get; set; }
    public IntervalType InType { get; set; }
    /// <summary>
    /// Изменение значения на каждом интервале
    /// </summary>
    public double Value { get;set; }

    /// Добавим модификаторы, чтобы учесть посторонние факторы: проценты, отчисления/округления и т.п.

    /// <summary>
    /// НЕ  ИСПОЛЬЗУЕТСЯ
    /// </summary>
    public double Duration { get; set; }


}
