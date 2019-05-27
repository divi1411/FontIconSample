using Xamarin.Forms;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            switch (e.SelectedItem)
            {
                case "First Page":
                    Navigation.PushAsync(new Firstpage());
                    break;
                case "Second Page":
                    Navigation.PushAsync(new SecondPage());
                    break;
            }
             ((ListView)sender).SelectedItem = null;
        }
    }
}