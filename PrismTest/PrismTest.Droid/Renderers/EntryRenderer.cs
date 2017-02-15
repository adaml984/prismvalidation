using PrismTest.Droid.Renderers;
using Xamarin.Forms;


[assembly: ExportRenderer(typeof(Entry), typeof(EntryRenderer))]
namespace PrismTest.Droid.Renderers
{
	public class EntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
	{

	}
}