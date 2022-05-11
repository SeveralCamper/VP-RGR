using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Champion_League_Football.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string _text1;

        public MainWindowViewModel()
        {
            Text1 = "Text";
        }
        public string Text1
        {
            get { return _text1; }
            set { this.RaiseAndSetIfChanged(ref _text1, value); }
        }
    }
}
