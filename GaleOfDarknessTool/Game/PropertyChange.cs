using System.ComponentModel;

namespace GaleOfDarknessTool
{

    public class CurrentFileItem : INotifyPropertyChanged
    {
        private int[] _value;

        public string Filename { get; set; }

        public int[] Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
