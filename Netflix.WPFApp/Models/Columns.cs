using System.Windows.Controls;

namespace Netflix.WPF.Models
{
    public class Columns
    {
        public Columns()
        {
            Col1 =  new Button();
            Col2 = new Button();
            Col3 = new Button();
            Col4 = new Button();
            Col5 = new Button();
            Col6 = new Button();
            Col7 = new Button();
            Col8 = new Button();
            Col9 = new Button();
            Col10 = new Button();
        }
        public Button Col1 { get; set; }
        public Button Col2 { get; set; }
        public Button Col3 { get; set; }
        public Button Col4 { get; set; }
        public Button Col5 { get; set; }
        public Button Col6 { get; set; }
        public Button Col7 { get; set; }
        public Button Col8 { get; set; }
        public Button Col9 { get; set; }
        public Button Col10 { get; set; }
    }
}
