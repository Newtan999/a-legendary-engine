using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VendasEstoque
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastrarCliente : ContentPage
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void BtnSalvarDB_Clicked(object sender, EventArgs e)
        {

        }
    }
}