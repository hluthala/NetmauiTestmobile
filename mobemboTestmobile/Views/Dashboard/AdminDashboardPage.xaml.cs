using mobemboTestmobile.ViewModels.Dashboard;

namespace mobemboTestmobile.Views.Dashboard;

public partial class AdminDashboardPage : ContentPage
{
	public AdminDashboardPage(AdminDashboardPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
