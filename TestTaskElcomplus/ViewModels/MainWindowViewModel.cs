using System.Windows;
using System.Windows.Input;
using TestTaskElcomplus.Commands;
using TestTaskElcomplus.ViewModels.Base;

namespace TestTaskElcomplus.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _title = "Тестовое задание Elcomplus";

        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Set(ref _title, value);
            }
        }
        #endregion

        #region Команды

        #region CloseAppCommand
        public ICommand CloseAppCommand { get; }

        /// <summary>
        /// Реализация команды - закрытие приложения
        /// </summary>
        /// <param name="p"></param>
        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Команда, закрыть приложение, доступна для выполнения всегда
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool CanCloseAppCommandExecute(object p) => true;
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);

            #endregion
        }

    }
}
