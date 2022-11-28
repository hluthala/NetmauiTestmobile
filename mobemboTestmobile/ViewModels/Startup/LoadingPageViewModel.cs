using System;
using mobemboTestmobile.Models;
using mobemboTestmobile.ViewModels.Base;
using mobemboTestmobile.Views;
using Newtonsoft.Json;

namespace mobemboTestmobile.ViewModels.Startup
{
    public partial class LoadingPageViewModel : BaseViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }
        private async void CheckUserLoginDetails()
        {
            //string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");

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
                await AppConstant.AddFlyoutMenusDetails();
            //}
        }

    }
}

