### Hey thanks for taking you time and doing this! 🙏

1. In this repository you can find working Xamarin.Forms app
2. The app is done with Prism, Fody.Property changed.
3. It has two views: Dashboard and WeatherView
4. When you run the application dashboard will be shown with a button that allows you to navigate to WeatherView

### The task

1. Please fork this repository to you own github account
2. Develop branch is your working branch
3. Develop what is described below.
4. Make a PR to this repository with what you have done.
5. You don't have to do everything. Just spent as much time as you want and create a PR.
6. After you make a PR, we will catch up on a call and review what you have done 👨‍💻

### Functional requirements

1. On the dashboard, please add a list of main cities in Poland (Gdańsk, Gdynia, Warsaw, Wroclaw, Lodz, Krakow, Poznan, Bydgosz, Szczecin, Katowice, Bialystok, Olsztyn, Kielc etc.)
   * those can be static
2. Having a list of main cities, after taping on city name, the view with weather in selected city should be opened. There is a command for doing so, so you will only need to use it and pass proper parameter.
   * on weather view, current weather in the city should be shown
   * you can either use mocked data, or you can hook up to any open API to show actual weather (eg. openweather API)

**Summing app.**

When you open the app a list of main cities should be presented.

After you tap on any city, it should open another view with weather in the chosen city.

### Non functional requirements
* please stick with MVVM and with PRISM
* please reuse (with adjustment) `OpenCityCommand` from `DashboardViewModel`
* you are free to use any library that you want but bear in mind that this repo is using centralised nuget versioning (adding packages described below)
* design is not provided, so do whatever you'd like to do

### How to add nuget packages?
1. In the browser, search for the package you want to add.
2. Open it on nuget's website
3. Copy it's name & version
4. Open packages.props file.
5. Add you package here
6. Add the package to each csproj file that you'd like to use it in.

**If you have any questions about the task or solution, feel free to write me. If you see this, then you should already have my email 😇**
