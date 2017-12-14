using System;
using System.Windows.Input;
using TouchpointApp.Persistency;
using TouchpointApp.ViewModel.Underviser;

namespace TouchpointApp.Command
{
    public class CreateUnderviserCommand :ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;


        public CreateUnderviserCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
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