using System;
using mobemboTestmobile.Controls;
using mobemboTestmobile.Views;
using mobemboTestmobile.Views.Dashboard;

namespace mobemboTestmobile.Models
{
    public class AppConstant
    {
        public async static Task AddFlyoutMenusDetails()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");

            var place = AppShell.Current.Items.Where(f => f.Route == nameof(PlacePage)).FirstOrDefault();

            if (place != null) AppShell.Current.Items.Remove(place);
            var maino = AppShell.Current.Items.Where(f => f.Route == nameof(MainPage)).FirstOrDefault();

            if (maino != null) AppShell.Current.Items.Remove(maino);
            var flyoutItems1 = new FlyoutItem()
            {
                //Title = "Accueil",
                //Route = nameof(MainPage),
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                Items =
                            {
                                new ShellContent
                                {
                                    Icon = Icons.home,
                                    Title = "Accueil",
                                    ContentTemplate = new DataTemplate(typeof(MainPage)),
                                    Route=nameof(MainPage)
                                },
                                new ShellContent
                                {
                                    Icon = Icons.Online,
                                    Title = "Place",
                                    ContentTemplate = new DataTemplate(typeof(PlacePage))
                                },
                                new ShellContent
                                {
                                    Icon = Icons.Setting,
                                    Title = "Setting",
                                    ContentTemplate = new DataTemplate(typeof(PlacePage))

                                },
                            }
            };
            if (!AppShell.Current.Items.Contains(flyoutItems1))
            {
                AppShell.Current.Items.Add(flyoutItems1);
                if (DeviceInfo.Platform == DevicePlatform.WinUI)
                {
                    AppShell.Current.Dispatcher.Dispatch(async () =>
                    {
                        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                        //await Shell.Current.GoToAsync($"//{nameof(PlacePage)}");
                    });
                }
                else
                {
                    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");

                    //await Shell.Current.GoToAsync($"//{nameof(PlacePage)}");
                }
            }
            var flyoutItems = new FlyoutItem()
            {
                Title = "Place",
                Route = nameof(PlacePage),
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                Items =
                            {
                               
                                new ShellContent
                                {
                                    Icon = Icons.Online,
                                    Title = "Place",
                                    ContentTemplate = new DataTemplate(typeof(PlacePage))
                                },
                                new ShellContent
                                {
                                    Icon = Icons.Setting,
                                    Title = "Setting",
                                    ContentTemplate = new DataTemplate(typeof(PlacePage))

                                },
                            }
            };
            if (!AppShell.Current.Items.Contains(flyoutItems))
            {
                AppShell.Current.Items.Add(flyoutItems);
                if (DeviceInfo.Platform == DevicePlatform.WinUI)
                {
                    AppShell.Current.Dispatcher.Dispatch(async () =>
                    {
                        //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                        await Shell.Current.GoToAsync($"//{nameof(PlacePage)}");
                    });
                }
                else
                {
                    //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");

                    await Shell.Current.GoToAsync($"//{nameof(PlacePage)}");
                }
            }

            if (!string.IsNullOrWhiteSpace(userDetailsStr))
            {
                var studentDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(StudentDashboardPage)).FirstOrDefault();
                if (studentDashboardInfo != null) AppShell.Current.Items.Remove(studentDashboardInfo);

                var teacherDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(TeacherDashboardPage)).FirstOrDefault();
                if (teacherDashboardInfo != null) AppShell.Current.Items.Remove(teacherDashboardInfo);

                var adminDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(AdminDashboardPage)).FirstOrDefault();
                if (adminDashboardInfo != null) AppShell.Current.Items.Remove(adminDashboardInfo);


                if (App.UserDetails.RoleID == (int)RoleDetails.Student)
                {
                    var flyoutItem = new FlyoutItem()
                    {
                        Title = "Dashboard Page",
                        Route = nameof(StudentDashboardPage),
                        FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                        Items =
                            {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Student Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(StudentDashboardPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Student Profile",
                                    ContentTemplate = new DataTemplate(typeof(StudentDashboardPage)),
                                },
                            }
                    };
                    if (!AppShell.Current.Items.Contains(flyoutItem))
                    {
                        AppShell.Current.Items.Add(flyoutItem);
                        if (DeviceInfo.Platform == DevicePlatform.WinUI)
                        {
                            AppShell.Current.Dispatcher.Dispatch(async () =>
                            {
                                await Shell.Current.GoToAsync($"//{nameof(StudentDashboardPage)}");
                            });
                        }
                        else
                        {
                            await Shell.Current.GoToAsync($"//{nameof(StudentDashboardPage)}");
                        }
                    }

                }

                if (App.UserDetails.RoleID == (int)RoleDetails.Teacher)
                {
                    var flyoutItem = new FlyoutItem()
                    {
                        Title = "Dashboard Page",
                        Route = nameof(TeacherDashboardPage),
                        FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                        Items =
                    {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Teacher Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(TeacherDashboardPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Teacher Profile",
                                    ContentTemplate = new DataTemplate(typeof(TeacherDashboardPage)),
                                },
                   }
                    };

                    if (!AppShell.Current.Items.Contains(flyoutItem))
                    {
                        AppShell.Current.Items.Add(flyoutItem);
                        if (DeviceInfo.Platform == DevicePlatform.WinUI)
                        {
                            AppShell.Current.Dispatcher.Dispatch(async () =>
                            {
                                await Shell.Current.GoToAsync($"//{nameof(TeacherDashboardPage)}");
                            });
                        }
                        else
                        {
                            await Shell.Current.GoToAsync($"//{nameof(TeacherDashboardPage)}");
                        }
                    }
                }

                if (App.UserDetails.RoleID == (int)RoleDetails.Admin)
                {
                    var flyoutItem = new FlyoutItem()
                    {
                        Title = "Dashboard Page",
                        Route = nameof(AdminDashboardPage),
                        FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                        Items =
                    {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Admin Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Admin Profile",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),
                                },
                   }
                    };

                    if (!AppShell.Current.Items.Contains(flyoutItem))
                    {
                        AppShell.Current.Items.Add(flyoutItem);
                        if (DeviceInfo.Platform == DevicePlatform.WinUI)
                        {
                            AppShell.Current.Dispatcher.Dispatch(async () =>
                            {
                                await Shell.Current.GoToAsync($"//{nameof(AdminDashboardPage)}");
                            });
                        }
                        else
                        {
                            await Shell.Current.GoToAsync($"//{nameof(AdminDashboardPage)}");
                        }
                    }


                }
            }

            
        }
    }
}

