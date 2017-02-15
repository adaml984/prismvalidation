using Android.OS;
using Android.Views.InputMethods;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using EntryRenderer = PrismTest.Droid.Renderers.EntryRenderer;


[assembly: ExportRenderer(typeof(Entry), typeof(EntryRenderer))]
namespace PrismTest.Droid.Renderers
{
	public class EntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
	{
		public EntryRenderer() { }

		public EntryRenderer(System.IntPtr z, Android.Runtime.JniHandleOwnership x)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.FocusChange += (sender, evt) =>
				{
					new Handler().Post(delegate
					{
						if (Control == null)
							return;
						var imm = (InputMethodManager)Control.Context.GetSystemService(Android.Content.Context.InputMethodService);
						var result = imm.HideSoftInputFromWindow(Control.WindowToken, 0);
					});
				};
			}
		}
	}
}