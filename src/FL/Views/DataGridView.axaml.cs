using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FL.Views
{
    public partial class DataGridView : UserControl
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
