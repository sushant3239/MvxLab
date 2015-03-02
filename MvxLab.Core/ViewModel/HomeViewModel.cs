
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
namespace MvxLab.Core.ViewModel
{
    public class HomeViewModel : MvxViewModel
    {
        private bool _showPopup = false;

        public HomeViewModel()
        {
            TestCommand = new MvxCommand(Test);
        }

        public ICommand TestCommand { get; set; }

        private void Test()
        {
            ShowPopup = true;
        }

        public bool ShowPopup
        {
            get { return _showPopup; }
            set
            {
                _showPopup = value;
                RaisePropertyChanged();
            }
        }
    }
}
