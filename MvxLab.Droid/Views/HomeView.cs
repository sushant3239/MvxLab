
using Android.App;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
namespace MvxLab.Droid.Views
{
    [Activity(Label = "MvxLab", MainLauncher = true)]
    public class HomeView : MvxActivity
    {
        private PopupWindow _popup;
        private Button _showPopupButton;

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(MvxLab.Droid.Resource.Layout.popupSample);           
        }        
    }
}