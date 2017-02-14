using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;

namespace PrismTest.ViewModels
{
	public class MainPageViewModelValidator : AbstractValidator<MainPageViewModel>
	{
		public MainPageViewModelValidator() { RuleFor(customer => customer.Title).NotEmpty().NotNull(); }
	}
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private MainPageViewModelValidator _validator = new MainPageViewModelValidator();
		private string _title;
		public string Title
		{
			get { return _title; }
			set
			{
				SetProperty(ref _title, value);
				var z = _validator.Validate(this);
				HasError = !z.IsValid;
			}
		}

		private bool _hasError;

		public bool HasError
		{
			get { return _hasError; }
			set
			{
				SetProperty(ref _hasError, value);
			}
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{

		}
	}
}
