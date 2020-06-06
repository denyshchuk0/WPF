using mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using mvvm.ViewModel.Helper;
using mvvm.ViewModel.Commands;

namespace mvvm.ViewModel
{
    public class VM : INotifyPropertyChanged
    {
        private string query;
        public ObservableCollection<City> Cities { get; set; } = new ObservableCollection<City>();
        public Curent currentConditiions;
        private City selectedCity;
        public SearchCommand SearchCommand { get; set; }
        public VM()
        {
            SearchCommand = new SearchCommand(this);
            Query = "";
        }
        public City SelectedCity
        {
            get { return selectedCity; }
            set
            {
                selectedCity = value;
                GetConditions();
                OnNotify();
            }
        }

        public Curent CurrentConditions
        {
            get => currentConditiions;
            set
            {

                currentConditiions   = value;
                OnNotify();

            }
        }

        public string Query
        {
            get => query;
            set
            {
                query = value;
                OnNotify();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotify([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public async void MakeRequestCities()
        {
            List<City> cities = await WeatherHelper.GetCities(Query); 
            Cities.Clear();
            foreach (var item in cities)
            {
                Cities.Add(item);
            }
        }

        private async void GetConditions()
        {
            if (SelectedCity != null)
            {
                CurrentConditions = await WeatherHelper.GetCurent(SelectedCity.Key);
            }
            else
                CurrentConditions = new Curent();
        }
    }
}


