using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotesRework
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void AddNote(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddPage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var listView = new ListView();
            listView.ItemsSource = await App.Database.GetNotesAsync();
        }
    }
}