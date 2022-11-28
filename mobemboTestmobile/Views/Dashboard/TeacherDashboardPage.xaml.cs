using mobemboTestmobile.ViewModels.Dashboard;

namespace mobemboTestmobile.Views.Dashboard;

public partial class TeacherDashboardPage : ContentPage
{
	public TeacherDashboardPage(TeacherDashboardPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
