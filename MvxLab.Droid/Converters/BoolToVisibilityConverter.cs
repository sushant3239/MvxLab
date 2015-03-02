

using Cirrious.CrossCore.Converters;
namespace MvxLab.Droid.Converters
{
    public class BoolToVisibilityConverter : IMvxValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool show = (bool)value;
            return show ? Android.Views.ViewStates.Visible : Android.Views.ViewStates.Invisible;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}