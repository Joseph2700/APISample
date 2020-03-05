using APISample.Models;
using APISample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace APISample.ViewModels
{
    public class APISampleViewModel : INotifyPropertyChanged
    {
        IApiService apiservice = new ApiService();

        public event PropertyChangedEventHandler PropertyChanged;
        public string TrackId { get; set; }
        public List<Track> TrackInfo { get; set; }
        public Track Track { get; set; } = new Track();
        public ICommand GetTrackCommand { get; set; }
        public APISampleViewModel()
        {
            GetTrackCommand = new Command(async () =>
            {
                await GetTrackInfo();
            });
        }
        async Task GetTrackInfo()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    var GetInfo = await apiservice.GetTrackInfo(TrackId);
                    TrackInfo = new List<Track>(GetInfo.Id);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API ERROR {ex}");
                    await App.Current.MainPage.DisplayAlert("Error", $"{ex}", "OK");
                }                
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "No hay conexion a internet", "Ok");
            }
        }
    }
}
