using mobemboTestmobile.ViewModels.Dashboard;

namespace mobemboTestmobile.Views.Dashboard;

public partial class StudentDashboardPage : ContentPage
{
	public StudentDashboardPage(StudentDashboardPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
