using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace LongPressEffectOnListView
{
    public class ItemModel : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public Command ItemLongPressCommand { get; set; }

        public ItemModel()
        {
            _name = "Not Set";
            ItemLongPressCommand = new Command(ItemLongPress);
        }

        private void ItemLongPress(object obj)
        {
            Name = "Long Press Item";
            System.Diagnostics.Debug.WriteLine("Cell View Long Press!!!");
        }

    }
}
