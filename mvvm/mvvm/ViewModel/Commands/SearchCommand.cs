using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {
        VM VM { get; set; }

        public SearchCommand(VM vm)
        {
            VM = vm;
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return !String.IsNullOrEmpty(parameter as string);
        }

        public void Execute(object parameter)
        {
            VM.MakeRequestCities();
        }
    }
}
