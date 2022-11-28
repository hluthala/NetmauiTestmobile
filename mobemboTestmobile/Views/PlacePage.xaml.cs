using mobemboTestmobile.ViewModels;

namespace mobemboTestmobile.Views;

public partial class PlacePage : ContentPage
{
	public PlacePage(PlacePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
