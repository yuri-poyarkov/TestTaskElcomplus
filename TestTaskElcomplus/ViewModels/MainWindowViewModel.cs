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


    }
}
