using System.Diagnostics;
using System.Reactive.Disposables;
using ReactiveUI;


namespace IViewForExample.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.WhenActivated(_ =>
            {

                Debug.WriteLine($"MainWindow.ViewModel is not null: {ViewModel is not null}");
            });
        }
    }
}
