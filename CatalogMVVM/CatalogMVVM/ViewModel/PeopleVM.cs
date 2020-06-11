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
        public ObservableCollection<People> peoples { get; set; } = new ObservableCollection<People>();

        public PeopleVM()
        {
            peoples.Add(new People() { 
            Name="a",
            Surname = "a",
            Number = "a"});
            peoples.Add(new People()
            {
                Name = "bbbbbbb",
                Surname = "a",
                Number = "a"
            });
        }
        People people;

        public People People
        {
            get { return people; }
            set { people = value;
                OnNotify();
            }
        }


        public void AddPeople() {
            peoples.Add(new People()
            {
                Name = People.Name,
                Surname = People.Surname,
                Number = People.Number,
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotify([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void MakeRequestPeople() { 
        
        }
        
    }
}
