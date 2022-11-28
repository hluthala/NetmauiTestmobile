using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mobemboTestmobile.Models;
using mobemboTestmobile.ViewModels.Base;
using mobemboTestmobile.Views;

namespace mobemboTestmobile.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        public AppShellViewModel()
        {
            CheckUserLoginDetails();
        }
        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");
            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                IsText = "Sign in";
            }
            else
            {
                IsText = "Sign out";

            }

            //if (string.IsNullOrWhiteSpace(userDetailsStr))
            //{
            //    if (DeviceInfo.Platform == DevicePlatform.WinUI)
            //    {
            //        AppShell.Current.Dispatcher.Dispatch(async () =>
            //        {
            //            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            //        });
            //    }
            //    else
            //    {
            //        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            //    }
            //    // navigate to Login Page
            //}
            //else
            //{
            //    var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(userDetailsStr);
            //    App.UserDetails = userInfo;
            //await AppConstant.AddFlyoutMenusDetails();
            //}
        }

        [ObservableProperty]
        string isText;


        [RelayCommand]

        async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails));
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}

