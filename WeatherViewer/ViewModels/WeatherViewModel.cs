using Prism.Navigation;

namespace WeatherViewer.ViewModels
{
    public class WeatherViewModel : BaseViewModel, IInitialize
    {
        public string? CityName { get; set; }

        public void Initialize(INavigationParameters parameters)
        {
            CityName = parameters.GetValue<string>("CityName");
        }
    }
}