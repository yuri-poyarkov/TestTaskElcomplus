using System;
using TestTaskElcomplus.Commands.Base;

namespace TestTaskElcomplus.Commands
{
    internal class RelayCommand : Command
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        /// <summary>
        /// Конструктор, в котором описаны два действия для команды
        /// </summary>
        /// <param name="Execute"></param>
        /// <param name="CanExecute"></param>
        public RelayCommand(Action<object> Execute, Func<object,bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        /// <summary>
        /// Проверка, можем ли мы выполнить какую либо команду
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override bool CanExecute(object parameter)
        {
            return _CanExecute?.Invoke(parameter) ?? true;
        }

        /// <summary>
        /// Основная логика команда, то что она должна выполнять
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter)
        { 
            _Execute(parameter);
        }
    }
}
