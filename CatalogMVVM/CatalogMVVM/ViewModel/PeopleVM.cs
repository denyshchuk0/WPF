using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMVVM.ViewModel
{
    class PeopleVM : INotifyPropertyChanged
    {
        private string query;
        public ObservableCollection<People> peoples { get; set; } = new ObservableCollection<People>();
        private People people;
        public PeopleVM()
        {
        }
        public People People
        {
            get { return people; }
            set
            {
                people = value;
             
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

        public void AddPeople() {
            peoples.Add(people);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotify([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        
    }
}
