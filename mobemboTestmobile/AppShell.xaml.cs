using mobemboTestmobile.ViewModels;

namespace mobemboTestmobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        this.BindingContext = new AppShellViewModel();
    }
}

