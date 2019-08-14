using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace VendasEstoque
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Clientes());
        }

        private void BtnProdutos_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnVendas_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEstoque_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnRelatório_Clicked(object sender, EventArgs e)
        {

        }
    }
}
