using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Emulator_8086
{
    sealed class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            RegisterParameters.PropertyChanged += (sender, args) => OnPropertyChanged(nameof(RegisterParameters));
        }
        public RegisterParameters RegisterParameters { get; set; } = new RegisterParameters();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
