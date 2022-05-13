using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WeatherAPI.Standard;
using WeatherAPI.Standard.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Web;

namespace WeatherAppClone.ViewModels
{
    public class WeatherPageViewModel : INotifyPropertyChanged, IQueryAttributable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public WeatherPageViewModel()
        {
            LocationName = "Thanh Pho Ho Chi Minh";

            Task.Run(async () =>
            {
                await GetWeatherData();
            });

            RefreshCommand = new Command(() =>
            {
                Task.Run(() =>
                {
                    GetWeatherData().GetAwaiter().OnCompleted(() =>
                    {
                        IsRefreshing = false;
                    });
                });
            });
        }

        async Task GetWeatherData()
        {
            try
            {
                WeatherAPIClient client = new WeatherAPIClient();
                //var forecastWeather = await client.APIs.GetForecastWeatherAsync(locationNames[locationIndex], 3);
                //locationIndex++;
                //if (locationIndex >= locationNames.Length) locationIndex = 0;

                var forecastWeather = await client.APIs.GetForecastWeatherAsync(LocationName, 3);

                LocationName = forecastWeather.Location.Name;
                CurrentWeather = forecastWeather.Current;

                //Get more data
                var weatherForecastDaysClone = new List<Forecastday>(forecastWeather.Forecast.Forecastday);
                weatherForecastDaysClone.AddRange(new List<Forecastday>(forecastWeather.Forecast.Forecastday));
                weatherForecastDaysClone.AddRange(new List<Forecastday>(forecastWeather.Forecast.Forecastday));

                WeatherForecastDays = new ObservableCollection<Forecastday>(weatherForecastDaysClone);

                //Join Hours of 2 days from now
                var weatherForecastHours48 = new List<Hour>(forecastWeather.Forecast.Forecastday[0].Hours);
                weatherForecastHours48.AddRange(new List<Hour>(forecastWeather.Forecast.Forecastday[1].Hours));

                //Find index of next Hour
                var nextHourIndex = weatherForecastHours48.IndexOf(weatherForecastHours48.Where(x => x.Time.CompareTo(forecastWeather.Location.Localtime) >= 0).FirstOrDefault());
                weatherForecastHours48.ForEach(x => x.Time = x.Time.Substring(11));

                //Get next 24 Hours from now
                WeatherForecastHours = new ObservableCollection<Hour>(weatherForecastHours48.GetRange(nextHourIndex, 24));
            }
            catch (Exception ex)
            {
                App.Current.Dispatcher.Dispatch(() =>
                {
                    App.Current.MainPage.DisplayAlert("WeatherApp", ex.Message, "OK");
                });
            }
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.Count == 0) return;
            LocationName = HttpUtility.UrlDecode(query["locationName"].ToString());

            Task.Run(() =>
            {
                GetWeatherData().GetAwaiter().OnCompleted(() =>
                {
                    IsRefreshing = false;
                });
            });
        }

        private string[] locationNames = new string[] { "Thanh pho Ho Chi Minh", "London", "Paris", "Washington" };
        private int locationIndex = 0;

        private string locationName;
        private Current currentWeather;
        private ObservableCollection<Hour> weatherForecastHours;
        private ObservableCollection<Forecastday> weatherForecastDays;
        private bool isRefreshing;

        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; OnPropertyChanged(); }
        }
        public Current CurrentWeather
        {
            get { return currentWeather; }
            set { currentWeather = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Hour> WeatherForecastHours
        {
            get { return weatherForecastHours; }
            set { weatherForecastHours = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Forecastday> WeatherForecastDays
        {
            get { return weatherForecastDays; }
            set { weatherForecastDays = value; OnPropertyChanged(); }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { isRefreshing = value; OnPropertyChanged(); }
        }

        public ICommand RefreshCommand { get; set; }
    }
}
