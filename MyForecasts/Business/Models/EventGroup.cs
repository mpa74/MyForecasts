using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForecasts.Business.Models;
/// <summary>
/// Группа событий, объединенная по каким-либо признакам (по типу)
/// </summary>
public class EventGroup
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }

    public ObservableCollection<EventDefinition> Events { get; set; } = [];
}
