

using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using MvxLab.Core.ViewModel;
namespace MvxLab.Core
{
    public class App : MvxApplication
    {
        public App()
        {
           Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        }
    }
}
