using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TouchpointApp.Model;
using TouchpointApp.Persistency;
using TouchpointApp.ViewModel.Underviser;

namespace TouchpointApp.Command
{
    public class CreateCommand : ICommand
    {

        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        private UnderviserViewmodel _uVM;

        public event EventHandler CanExecuteChanged;

        public CreateCommand(Action execute)
            : this(execute, null)
        {

        }

        public CreateCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return ((_canExecute == null) || _canExecute());
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}