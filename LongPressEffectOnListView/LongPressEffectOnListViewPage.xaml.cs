using System.Collections.Generic;
using Xamarin.Forms;

namespace LongPressEffectOnListView
{
    public partial class LongPressEffectOnListViewPage : ContentPage
    {
        public LongPressEffectOnListViewPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel(ItemList);
        }
    }
}
