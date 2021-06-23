using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace IViewForExample.ViewModels
{
    public class MyUserControlViewModel : ReactiveObject
    {

        private string _appName = "Hello App";
        public string AppName
        {
            get => _appName;
            set => this.RaiseAndSetIfChanged(ref _appName, value);
        }
    }
}
