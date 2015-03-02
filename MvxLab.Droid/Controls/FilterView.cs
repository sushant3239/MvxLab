
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;
namespace MvxLab.Droid.Controls
{
    public class FilterView : LinearLayout
    {
        public FilterView(Context context)
            : base(context, null)
        {
            Orientation = Android.Widget.Orientation.Vertical;
            SetGravity(GravityFlags.CenterVertical);
            
        }

        public FilterView(Context context, IAttributeSet attr) :
            base(context, attr)
        {
            Orientation = Android.Widget.Orientation.Vertical;
            var view = Inflate(Context, Resource.Layout.popup_layout, null);
            AddView(view);          
        }
    }
}