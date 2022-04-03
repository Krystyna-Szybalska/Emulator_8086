using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Emulator_8086
{
    public enum Registers
    {
        AX,
        BX,
        CX,
        DX
    }

    public class RegisterParameters : INotifyPropertyChanged
    {
        private string? _ax;
        private string? _bx;
        private string? _cx;
        private string? _dx;

        public string? Ax
        {
            get => _ax;
            set
            {
                _ax = value;
                OnPropertyChanged(nameof(Ax));
            }
        }
        public string? Bx
        {
            get => _bx;
            set
            {
                _bx = value;
                OnPropertyChanged(nameof(Bx));
            }
        }
        public string? Cx
        {
            get => _cx;
            set
            {
                _cx = value;
                OnPropertyChanged(nameof(Cx));
            }
        }
        public string? Dx
        {
            get => _dx;
            set
            {
                _dx = value;
                OnPropertyChanged(nameof(Dx));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        //obsluga bledow na inpucie
        //int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
    }
}
