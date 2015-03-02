

using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using MvxLab.Core;
using MvxLab.Droid.Converters;
namespace MvxLab.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context context)
            : base(context)
        {

        }
        protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override System.Collections.Generic.List<System.Reflection.Assembly> ValueConverterAssemblies
        {
            get
            {
                var conveterCollection =  base.ValueConverterAssemblies;
                conveterCollection.Add(typeof(BoolToVisibilityConverter).Assembly);
                return conveterCollection;
            }
        }
    }
}