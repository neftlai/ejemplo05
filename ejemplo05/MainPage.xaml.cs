namespace ejemplo05
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            (sender as Button).Text = "presioname de nuevo";
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
        }
    }

}
