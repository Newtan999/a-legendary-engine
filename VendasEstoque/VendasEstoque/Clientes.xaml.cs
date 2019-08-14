using System;
using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VendasEstoque
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clientes : ContentPage
    {
        private ViewModel _viewModel = new ViewModel();
        public Clientes()
        {
            InitializeComponent();
            this.List.ItemsSource = this._viewModel.Items;
        }

        protected void ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var items = this.List.ItemsSource as IList;

            if (items != null && e.Item == items[items.Count - 1])
            {
                this._viewModel.Load();
            }
        }

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetalheClientes());
        }

        private void ToolbarBusca_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarCadastra_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastrarCliente());

        }
    }
}