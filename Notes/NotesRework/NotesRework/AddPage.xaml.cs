using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesRework
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(descriptionEntry.Text))
            {
                await App.Database.SaveNoteAsync(new Note
                {
                    Name = nameEntry.Text,
                    Description = descriptionEntry.Text,
                    Date = DateTime.Now
                }) ;

                nameEntry.Text = descriptionEntry.Text = string.Empty;
                //listView.ItemsSource = await App.Database.GetNotesAsync();
            }
            await Navigation.PopAsync();
        }
    }
}