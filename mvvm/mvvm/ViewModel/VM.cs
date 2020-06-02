using mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModel
{
    public class VM : INotifyPropertyChanged
    {
        private string query;
        public ObservableCollection<City> cities { get; set; } = new ObservableCollection<City>();
        public string Query { get =>query; set {
                query = value; OnNotify();
            }}
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotify([CallerMemberName] string prop = "") {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

