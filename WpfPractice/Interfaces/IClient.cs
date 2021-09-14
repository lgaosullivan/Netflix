using System.Collections.Generic;
using System.Threading.Tasks;

namespace Netflix.WPFApp.Interfaces
{
    public interface IClient
    {
        public Task<IEnumerable<Netflix.WPFApp.Models.Netflix>> BindEmployeeList();
    }
}
