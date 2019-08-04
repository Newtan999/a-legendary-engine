using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

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
        }
}