using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace LongPressEffectOnListView
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _labelName;

        public Command LabelLongPressCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public List<ItemModel> items = new List<ItemModel>();

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

        public ViewModel(ListView ItemList)
        {
            LabelName = "Label, long press for effects";
            ItemList.ItemsSource = items;
            LabelLongPressCommand = new Command(LabelLongPress);
            PopulateList();
        }

		private void PopulateList()
		{
			int max = 10;
			
			for (int i = 1; i <= max; i++)
			{
				items.Add(new ItemModel { Name = "Item " + i });
			}
		}

        private void LabelLongPress(object obj)
        {
            LabelName = "Long Press Label";
            System.Diagnostics.Debug.WriteLine("Label Long Press");
        }


    }
}
