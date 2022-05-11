using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Champion_League_Football.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandlerOnClick(object sender, RoutedEventArgs eventHandler)
        {
           this.FindControl<TextBox>("TextBox1").Text = "Button Clicked";
        }
    }
}
