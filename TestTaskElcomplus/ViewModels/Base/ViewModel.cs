using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTaskElcomplus.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие изменения свойства</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Генерация смены значения свойства</summary>
        /// <param name="PropertyName">Имя свойства, которое мы хотим изменить</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Метод для обновления значения свойства,
        /// для которого определено поле в котором это свойство хранит свои данные </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">Ссылка на поле свойства</param>
        /// <param name="value">Новое значение, которое хотим установить</param>
        /// <param name="PropertyName">Имя свойства, которое мы хотим изменить</param>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
