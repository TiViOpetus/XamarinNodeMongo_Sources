using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Refit;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> _messages;
        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }
        public MainPage()
        {
            InitializeComponent();
            _messages = new ObservableCollection<string>();
            listView.ItemsSource = _messages;
        }

        int count = 0;
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var authAPI = RestService.For<IAuthAPI>("http://10.0.2.2:3000");
            string result = await authAPI.HelloWorld();
            count++;
            ((Button)sender).Text = result +  " received " + count.ToString() + " times.";
        }

        async void Handle_Add(object sender, System.EventArgs e)
        {
            var authAPI = RestService.For<IAuthAPI>("http://10.0.2.2:3000");
            string result = await authAPI.Add();
            infoLabel.Text = result;
        }

        async void Handle_List(object sender, System.EventArgs e)
        {
            _messages.Clear();
            var authAPI = RestService.For<IAuthAPI>("http://10.0.2.2:3000");
            List<ListEntry> result = await authAPI.List();
            foreach(ListEntry s in result)
            {
                _messages.Add(s.testidata);
            }
        }
    }
}
