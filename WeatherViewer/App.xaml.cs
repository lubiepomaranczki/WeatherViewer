using System;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using WeatherViewer.ViewModels;
using WeatherViewer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherViewer
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer? initializer = null) : base(initializer)
        {
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<WeatherPage, WeatherViewModel>();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
        }

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync("DashboardPage");
        }

        protected override void OnResume()
        {
        }
    }
}
