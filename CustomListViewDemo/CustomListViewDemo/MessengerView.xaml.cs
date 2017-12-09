using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomListViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessengerView : ContentPage
    {
        public MessengerView()
        {
            InitializeComponent();
            ListMessages.ItemsSource = new Messenger().GetMessages();
        }

        private void ListMessages_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListMessages.SelectedItem = null;
        }
    }
}