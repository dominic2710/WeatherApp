using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WeatherAPI.Standard.Models;
using WeatherAPI.Standard;
using System.Windows.Input;

namespace WeatherAppClone.ViewModels
{
    public  class FavoritePageViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string[] locationNames = new string[] { "Thanh pho Ho Chi Minh", "London", "Paris", "Washington" };

        public FavoritePageViewModel()
        {
            Task.Run(async () =>
            {
                await GetFavoriteData();
            });

            SelectLocationCommand = new Command<CurrentJsonResponse>(async (CurrentJsonResponse param) =>
                {
                    await Shell.Current.GoToAsync($"//weather?locationName={param.Location.Name}");
                });
        }

        async Task GetFavoriteData()
        {
            WeatherAPIClient weatherAPIClient = new WeatherAPIClient();
            WeatherForcastDays = new ObservableCollection<CurrentJsonResponse>();
            foreach (string locationName in locationNames)
            {
                var forcastWeather = await weatherAPIClient.APIs.GetRealtimeWeatherAsync(locationName);
                WeatherForcastDays.Add(forcastWeather);
            }
        }

        private ObservableCollection<CurrentJsonResponse> weatherForcastDays;

        public ObservableCollection<CurrentJsonResponse> WeatherForcastDays
        {
            get { return weatherForcastDays; }
            set { weatherForcastDays = value; OnPropertyChanged(); }
        }

        public ICommand SelectLocationCommand { get; set; } 
    }
}
