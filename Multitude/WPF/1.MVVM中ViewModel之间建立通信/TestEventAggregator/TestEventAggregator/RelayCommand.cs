using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Input;

namespace TestEventAggregator
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action _execute;
        private Func<bool>? _canExecute;
        public RelayCommand(Action action, Func<bool> canExecute = null)
        {
            _execute = action;
            _canExecute = canExecute;
        }



        public bool CanExecute(object? parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute();
        }

        //bool ICommand.CanExecute(object? parameter)
        //{
        //    throw new NotImplementedException();
        //}

        void ICommand.Execute(object? parameter)
        {
            _execute();
        }



    }
    public class RelayCommand<T> : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<T> _execute;
        private Func<T, bool> _canExecute;
        public RelayCommand(Action<T> action, Func<T, bool> canExecute = null)
        {
            _execute = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute((T)parameter);
        }

        public void Execute(object? parameter)
        {
            _execute((T)parameter);
        }
    }
}
