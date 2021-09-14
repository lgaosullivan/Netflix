
namespace Netflix.WPFApp.Models
{
    public static class Storage
    {
        private static string Id;
        public static string TrackClicks
        {
            get
            {
                return (Id);
            }
            set
            {
                Id = value;
            }
        }
    }
}
