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

        /// <summary>
        /// Проверка, можно ли выполнить эту команду в данный момент
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// Основная логика команды, которую она должна выполнять
        /// </summary>
        /// <param name="parameter"></param>
        public abstract void Execute(object parameter);
    }
}
