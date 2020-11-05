using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppForChildren_MVVM_.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChancged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChancged(PropertyName);
            return true;
        }
     }
}
