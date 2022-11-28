using mobemboTestmobile.ViewModels.Startup;

namespace mobemboTestmobile.Views.Startup;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
