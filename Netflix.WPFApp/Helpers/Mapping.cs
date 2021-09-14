using System.Collections.Generic;
using System.Linq;
using Netflix.WPFApp.Interfaces;
using Netflix.WPFApp.Models;

namespace Netflix.WPF.Helpers
{
    public class Mapping : IMapping
    {
        public IEnumerable<Netflix.WPF.Models.Columns> ColumnsMap(IEnumerable<Netflix.WPFApp.Models.Netflix> Netflix)
        {
            int i, j;
            var columns = new List<Netflix.WPF.Models.Columns>();
            j = 0;

            for (i = 0; i < 10; i++)
            {
                var netflix = Netflix.Select(x => x).Skip(j).Take(10).ToArray();

                var group = new Netflix.WPF.Models.Columns();
                if (Storage.TrackClicks == "PreviousIsId")
                {
                    group.Col1.Content = netflix.ElementAt(0).UserId;
                    group.Col2.Content = netflix.ElementAt(1).UserId;
                    group.Col3.Content = netflix.ElementAt(2).UserId;
                    group.Col4.Content = netflix.ElementAt(3).UserId;
                    group.Col5.Content = netflix.ElementAt(4).UserId;
                    group.Col6.Content = netflix.ElementAt(5).UserId;
                    group.Col7.Content = netflix.ElementAt(6).UserId;
                    group.Col8.Content = netflix.ElementAt(7).UserId;
                    group.Col9.Content = netflix.ElementAt(8).UserId;
                    group.Col10.Content = netflix.ElementAt(9).UserId;
                }
                else if (Storage.TrackClicks == "PreviousIsUserId")
                {
                    group.Col1.Content = netflix.ElementAt(0).Id;
                    group.Col2.Content = netflix.ElementAt(1).Id;
                    group.Col3.Content = netflix.ElementAt(2).Id;
                    group.Col4.Content = netflix.ElementAt(3).Id;
                    group.Col5.Content = netflix.ElementAt(4).Id;
                    group.Col6.Content = netflix.ElementAt(5).Id;
                    group.Col7.Content = netflix.ElementAt(6).Id;
                    group.Col8.Content = netflix.ElementAt(7).Id;
                    group.Col9.Content = netflix.ElementAt(8).Id;
                    group.Col10.Content = netflix.ElementAt(9).Id;
                }
                columns.Add(group);

                j = j + 10;
            }

            if (Storage.TrackClicks == "PreviousIsId")
            {
                Storage.TrackClicks = "PreviousIsUserId";
            }
            else if (Storage.TrackClicks == "PreviousIsUserId")
            {
                Storage.TrackClicks = "PreviousIsId";
            }
            return columns;
        }
    }
}
