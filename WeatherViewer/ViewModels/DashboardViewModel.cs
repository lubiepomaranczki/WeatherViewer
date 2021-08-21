using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;

namespace WeatherViewer.ViewModels
{
    public class DashboardViewModel:BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand<string> OpenCityCommand { get; }

        public DashboardViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            OpenCityCommand = new DelegateCommand<string>(OpenCity);
        }

        private void OpenCity(string cityName)
        {
            //TODO this should come from command
            cityName = "Gdynia";

            var navigationParameters = new NavigationParameters
            {
                {"CityName", "Gdynia"}
            };
            _navigationService.NavigateAsync("NavigationPage/WeatherPage", navigationParameters);
        }
    }
}