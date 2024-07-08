using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentacar.ViewModel
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy;
        string? title;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;
                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }
        public string? Title
        {
            get => title;
            set
            {
                if (title == value) return;
                title = value;
                OnPropertyChanged();
            }
        }
        public bool IsNotBusy=> !isBusy;
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string? name=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
