using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;

namespace IViewForExample.Views
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl
    {
        public MyUserControl()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {

                Debug.WriteLine($"MyUserControl.ViewModel is not null: {ViewModel is not null}");


                this.Bind(ViewModel, vm => vm.AppName, view => view.AppNameTextBox.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
