﻿using mobemboTestmobile.ViewModels;

namespace mobemboTestmobile.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
