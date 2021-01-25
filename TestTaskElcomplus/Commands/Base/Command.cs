using System;
using System.Windows.Input;

namespace TestTaskElcomplus.Commands.Base
{
    internal abstract class Command : ICommand
    {
        /// <summary>
        /// Передача управления событием(команда) классу CommandManager
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
