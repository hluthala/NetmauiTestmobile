﻿using Microsoft.Maui.Platform;
using mobemboTestmobile.Handlers;
using mobemboTestmobile.Models;

namespace mobemboTestmobile;

public partial class App : Application
{
    public static UserBasicInfo UserDetails;

    public App()
	{
		InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
            if (view is BorderlessEntry)
            {
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif __IOS__
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            }
        });
        MainPage = new AppShell();
	}
}

