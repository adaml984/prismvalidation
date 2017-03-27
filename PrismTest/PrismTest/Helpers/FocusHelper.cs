using Xamarin.Forms;

namespace PrismTest.Helpers
{
	public static class FocusHelper
	{
		public static readonly BindableProperty FocusedElementProperty =
			BindableProperty.CreateAttached(
				"FocusedElement",
				typeof(bool),
				typeof(BindableObject),
				false,
				propertyChanged: OnPropertyChanged);

		public static void SetFocusedElement(View view, bool shouldFocus)
		{
			if (view != null && shouldFocus)
				view.Focus();
		}

		public static bool GetFocusedElement(View view) { return view?.IsFocused ?? false; }

		private static void OnPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
		{
			if (newvalue == null)
				return;
			SetFocusedElement(bindable as View, (bool) newvalue);
		}
	}
}