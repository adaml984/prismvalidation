using Xamarin.Forms;
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
	}
}