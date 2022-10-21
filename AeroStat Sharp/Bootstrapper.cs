using AeroStat_Sharp.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace AeroStat_Sharp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
