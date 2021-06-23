using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using IViewForExample.ViewModels;
using IViewForExample.Views;
using ReactiveUI;
using SimpleInjector;
using Splat;
using Splat.SimpleInjector;

namespace IViewForExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);
            var initializer = new SimpleInjectorInitializer();
            Locator.SetLocator(initializer);

            // Register ReactiveUI dependencies
            Locator.CurrentMutable.InitializeSplat();
            Locator.CurrentMutable.InitializeReactiveUI();

            // Register SimpleInjector
            var container = new Container();

            // Actual SimpleInjector registration
            container.UseSimpleInjectorDependencyResolver(initializer);

            // Registering Views
            container.Register<MainWindow>();
            container.Register<MyUserControl>();


            container.Register<MainWindowViewModel>();
            container.Register<MyUserControlViewModel>();


            container.Register<IViewFor<MainWindowViewModel>, MainWindow>();
            container.Register<IViewFor<MyUserControlViewModel>, MyUserControl>();


            var mainWindow = container.GetInstance<MainWindow>();

            mainWindow.Show();
        }
    }
}
