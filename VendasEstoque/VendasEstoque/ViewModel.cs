using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text;


namespace VendasEstoque
{
    public class ViewModel
    {
        public ObservableCollection<string> Items
        {
            get;
            set;
        }
        public ViewModel()
        {
            this.Items = new ObservableCollection<string>();
            this.Load();
        }
        private int _index = 0;
        public void Load()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Items.Add(string.Format("Cliente {0}", _index++));

            }
        }

    }
}
