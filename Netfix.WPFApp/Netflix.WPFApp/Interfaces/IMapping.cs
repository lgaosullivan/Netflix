using System.Collections.Generic;

namespace Netflix.WPFApp.Interfaces
{
    public interface IMapping
    {
        IEnumerable<Netflix.WPF.Models.Columns> ColumnsMap(IEnumerable<Netflix.WPFApp.Models.Netflix> Netflix);
    }
}
