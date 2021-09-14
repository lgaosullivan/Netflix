using System.Windows;
using Netflix.WPFApp.Models;
using Netflix.WPFApp.Interfaces;
using Microsoft.Extensions.Options;

namespace Netflix.WPFApp
{
    public partial class MainWindow : Window
    {
        public IMapping _Mapping;
        public IClient _Client;


        public readonly AppSettings Settings;
        public MainWindow(IMapping Mapping, IClient Client, IOptions<AppSettings> Settings)
        {
            _Mapping = Mapping;
            _Client = Client;

            this.Settings = Settings.Value;

            InitializeComponent();
            var netflix = Client.BindEmployeeList();

            Storage.TrackClicks = "PreviousIsUserId";
            var columns = _Mapping.ColumnsMap(netflix.Result);

            dataGrid.ItemsSource = columns;
        }

        private async void Btn_Click(object sender, RoutedEventArgs e)
        {
            var netflix = await _Client.BindEmployeeList();

            var columns = _Mapping.ColumnsMap(netflix);

            dataGrid.ItemsSource = columns;
        }
    }
}