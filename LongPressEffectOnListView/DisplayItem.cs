using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace LongPressEffectOnListView
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _itemName;
        private string _labelName;

        public Command LongPressItemCommand { get; set; }
        public Command LongPressLabelCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public List<ViewModel> itemList = new List<ViewModel>();

        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItemName)));
            }
        }

        public string LabelName
        {
            get
            {
                return _labelName;
            }
            set
            {
                _labelName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LabelName)));
            }
        }

        public ViewModel()
        {
            PopulateList();
            LongPressItemCommand = new Command(LongPressItem);
            LongPressLabelCommand = new Command(LongPressLabel);
        }

        private void PopulateList()
        {
            int max = 10;

            for (int i = 1; i <= max; i++)
            {
                itemList.Add(new ViewModel { ItemName = "Item " + i });
            }
        }

        private void LongPressItem(object obj)
        {
            ItemName = "Long Press Item";
            System.Diagnostics.Debug.WriteLine("Cell View Long Press!!!");
        }

        private void LongPressLabel(object obj)
        {
            ItemName = "Long Press Label";
            System.Diagnostics.Debug.WriteLine("Label Long Press!!!");
        }
    }
}
